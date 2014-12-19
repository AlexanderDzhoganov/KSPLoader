using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil;
using System.Reflection;
using Mono.Cecil.Cil;

namespace KSPLoader
{
    class Program
    {
        static float GetFooPatched()
        {
            return 3.1415f;
        }

        private static void ProcessMethod(MethodDefinition method, TypeReference lookFor, TypeDefinition replaceWith)
        {
            Console.WriteLine("Patching method {0}", method.FullName);

            TypeReference importedReplaceWith = method.Module.Import(replaceWith); 

            if (method.HasBody)
            {
                Mono.Collections.Generic.Collection<Instruction> instructions = method.Body.Instructions;
                Mono.Collections.Generic.Collection<VariableDefinition> types = method.Body.Variables;

                if (method.ReturnType == lookFor)
                {
                    method.ReturnType = method.Module.Import(replaceWith);
                    Console.WriteLine("Patching return type: Replacing {0} with {1}", lookFor.Name, replaceWith.Name);
                }

                for (int i = 0; i < types.Count; i++)
                {
                    if (method.Body.Variables[i].VariableType == lookFor)
                    {
                        method.Body.Variables[i].VariableType = importedReplaceWith;
                        Console.WriteLine("Patching local variable: Replacing {0} with {1}", lookFor.Name, replaceWith.Name);
                    }
                }

                for (int i = 0; i < instructions.Count; i++)
                {
                    Instruction instruction = instructions[i];
                    var operandType = instruction.OpCode.OperandType;

                    if (operandType == OperandType.InlineType)
                    {
                        var typeRef = (TypeReference)instruction.Operand;
                        if (typeRef.DeclaringType == lookFor)
                        {
                            typeRef = importedReplaceWith;
                            Console.WriteLine("Patching InlineMethod: Replacing {0} with {1}", lookFor.Name, replaceWith.Name);
                        }
                    }
                    else if (operandType == OperandType.InlineMethod)
                    {
                        var methodRef = (MethodReference)instruction.Operand;
                        var methodName = methodRef.Name;

                        if (methodRef.DeclaringType == lookFor)
                        {
                            foreach (var replaceMethod in replaceWith.Methods)
                            {
                                if (replaceMethod.Name == methodName)
                                {
                                    instruction.Operand = method.Module.Import(replaceMethod);
                                    Console.WriteLine("Patching InlineMethod: Replacing {0}::{1} with {2}::{3}", lookFor.Name, methodName, replaceWith.Name, replaceMethod.Name);
                                    break;
                                }
                            }

                        }
                    }
                    else if (operandType == OperandType.InlineField)
                    {
                        var fieldRef = (FieldReference)instruction.Operand;
                        var fieldName = fieldRef.Name;

                        if (fieldRef.DeclaringType == lookFor)
                        {
                            foreach (var replaceField in replaceWith.Fields)
                            {
                                if (replaceField.Name == fieldName)
                                {
                                    instruction.Operand = method.Module.Import(replaceField);
                                    Console.WriteLine("Patching InlineField: Replacing {0}::{1} with {2}::{3}", lookFor.Name, fieldName, replaceWith.Name, replaceField.Name);
                                    break;
                                }
                            }
                        }
                    }
                }   
            }
        }

        static void Main(string[] args)
        {
            AssemblyDefinition myLibrary = AssemblyDefinition.ReadAssembly("C:/Users/Alex Dzhoganov/Documents/GitHub/KSPLoader/TestLib/bin/Debug/TestLib.dll");

            var fooType = myLibrary.MainModule.GetType("TestLib", "Foo");

            TypeInfo barTypeInfo = typeof(PatchLib.Bar).GetTypeInfo();
            var barType = myLibrary.MainModule.Import(barTypeInfo).Resolve();

            Console.WriteLine("Replacing all TestLib.Foo references with PatchLib.Bar");
            foreach (var typeDef in myLibrary.MainModule.Types)
            {
                foreach (var methodDef in typeDef.Methods)
                {
                    var name = methodDef.FullName;
                    if (name == "System.Single TestLib.Test::TestFoo()" || name == "TestLib.Foo TestLib.Test::ReturnNewFoo()")
                    {
                        ProcessMethod(methodDef, fooType, barType);
                    }
                }
            }

            myLibrary.Write("C:/Users/Alex Dzhoganov/Documents/GitHub/KSPLoader/TestLib/bin/Debug/TestLib.dll");
            Console.WriteLine("Assembly succesfully patched");

            for (; ; ) ;
        }
    }
}
