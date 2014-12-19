using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            bool methodPatched = false;

            TypeReference importedReplaceWith = method.Module.Import(replaceWith); 

            if (method.HasBody)
            {
                Mono.Collections.Generic.Collection<Instruction> instructions = method.Body.Instructions;
                Mono.Collections.Generic.Collection<VariableDefinition> types = method.Body.Variables;

                if (method.ReturnType == lookFor)
                {
                    method.ReturnType = method.Module.Import(replaceWith);
                    Console.WriteLine("Patching return type: Replacing {0} with {1}", lookFor.FullName, replaceWith.FullName);
                    methodPatched = true;
                }

                for (int i = 0; i < types.Count; i++)
                {
                    if (method.Body.Variables[i].VariableType == lookFor)
                    {
                        method.Body.Variables[i].VariableType = importedReplaceWith;
                        Console.WriteLine("Patching local variable: Replacing {0} with {1}", lookFor.FullName, replaceWith.FullName);
                        methodPatched = true;
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
                            Console.WriteLine("Patching InlineMethod: Replacing {0} with {1}", lookFor.FullName, replaceWith.FullName);
                            methodPatched = true;
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
                                    Console.WriteLine
                                    (
                                        "Patching InlineMethod: Replacing {0}::{1} with {2}::{3}",
                                        lookFor.FullName, methodName, replaceWith.FullName, replaceMethod.Name
                                    );
                                    methodPatched = true;
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
                                    methodPatched = true;
                                    break;
                                }
                            }
                        }
                    }
                }   
            }

            if (methodPatched)
            {
                Console.WriteLine("Patched method {0}", method.FullName);
            }
        }

        private static void ProcessField(FieldDefinition field, TypeReference lookFor, TypeDefinition replaceWith)
        {
            var fieldTypeName = field.Resolve().FieldType.Name;
            var lookForTypeName = lookFor.Name;

            if (fieldTypeName == lookForTypeName)
            {
                Console.WriteLine("Patching Field: Replacing {0} with {1}", lookFor.FullName, replaceWith.FullName);
            }
        }

        private static void ProcessProperty(PropertyDefinition property, TypeReference lookFor, TypeDefinition replaceWith)
        {
            var fieldTypeName = property.Resolve().PropertyType.Name;
            var lookForTypeName = lookFor.Name;

            if (fieldTypeName == lookForTypeName)
            {
                Console.WriteLine("Patching Property: Replacing {0} with {1}", lookFor.FullName, replaceWith.FullName);
            }
        }

        static void Main(string[] args)
        {
            AssemblyDefinition myLibrary = AssemblyDefinition.ReadAssembly("C:/Users/Alex Dzhoganov/Desktop/Assembly-CSharp.dll");

            var fooType = myLibrary.MainModule.GetType("", "XKCDColors");
            if (fooType == null)
            {
                Console.WriteLine("Error, could not find type RnDBuilding in Assembly-CSharp");
                return;
            }

            var barType = myLibrary.MainModule.Import(typeof(PatchLib.XKCDColors)).Resolve();

            Console.WriteLine("Replacing all Assembly-CSharp.RndBuilding references with PatchLib.RnDBuilding");
            foreach (var typeDef in myLibrary.MainModule.Types)
            {
                if (typeDef.Name == fooType.Name)
                {
                    continue;
                }

                foreach (var methodDef in typeDef.Methods)
                {
                    ProcessMethod(methodDef, fooType, barType);
                }

                foreach (var fieldDef in typeDef.Fields)
                {
                    ProcessField(fieldDef, fooType, barType);
                }

                foreach (var propertyDef in typeDef.Properties)
                {
                    ProcessProperty(propertyDef, fooType, barType);
                }
            }

            myLibrary.Write("C:/Users/Alex Dzhoganov/Desktop/Assembly-CSharp_patched.dll");
            Console.WriteLine("Assembly succesfully patched");

            for (; ; ) ;
        }
    }
}
