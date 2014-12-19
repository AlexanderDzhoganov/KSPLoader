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

        private static void ProcessMethod(MethodDefinition method, TypeReference lookFor, TypeReference replaceWith)
        {
            if (method.HasBody)
            {
                Mono.Collections.Generic.Collection<Instruction> instructions = method.Body.Instructions;

                for (int i = 0; i < instructions.Count; i++)
                {
                    Instruction instruction = instructions[i];
                    var operandType = instruction.OpCode.OperandType;

                    if (operandType == OperandType.InlineMethod)
                    {
                        var methodRef = (MethodReference)instruction.Operand;
                        if (methodRef.DeclaringType == lookFor)
                        {
                            ((MethodReference)instruction.Operand).DeclaringType = replaceWith;
                            Console.WriteLine("Patching InlineMethod: Replacing {0} with {1}", lookFor.Name, replaceWith.Name);
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
            var barType = myLibrary.MainModule.Import(barTypeInfo);

            Console.WriteLine("Replacing all TestLib.Foo references with PatchLib.Bar");
            foreach (var typeDef in myLibrary.MainModule.Types)
            {
                foreach (var methodDef in typeDef.Methods)
                {
                    ProcessMethod(methodDef, fooType, barType);
                }
            }

            myLibrary.Write("C:/Users/Alex Dzhoganov/Documents/GitHub/KSPLoader/TestLib/bin/Debug/TestLib.dll");
            Console.WriteLine("Assembly succesfully patched");

            for (; ; ) ;
        }
    }
}
