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

        static void Main(string[] args)
        {
            AssemblyDefinition myLibrary = AssemblyDefinition.ReadAssembly("C:/Users/Alex Dzhoganov/Documents/GitHub/KSPLoader/TestLib/bin/Debug/TestLib.dll");

            MethodInfo writeLineMethod = typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) });

            //Gets all types which are declared in the Main Module of "MyLibrary.dll"
            foreach (TypeDefinition type in myLibrary.MainModule.Types)
            {
                //Writes the full name of a type
                Console.WriteLine("Got type: " + type.FullName);

                foreach (FieldDefinition field in type.Fields)
                {
                    Console.WriteLine("field - " + field.Name);
                }

                foreach (MethodDefinition method in type.Methods)
                {
                    Console.WriteLine("method - " + method.Name);

                    if (method.Name == "GetFoo")
                    {
                        Console.WriteLine("Found Foo method");

                        var processor = method.Body.GetILProcessor();

                        string sentence = String.Concat("Code added in ", method.Name);

                        //Import the Console.WriteLine() method
                        var writeLine = myLibrary.MainModule.Import(writeLineMethod);

                        //Creates the MSIL instruction for inserting the sentence
                        var insertSentence = processor.Create(OpCodes.Ldstr, sentence);

                        //Creates the CIL instruction for calling the
                        //Console.WriteLine(string value) method
                        var callWriteLine = processor.Create(OpCodes.Call, writeLine);

                        //Getting the first instruction of the current method
                        var ins = method.Body.Instructions[0];

                        //Inserts the insertSentence instruction before the first //instruction
                        processor.InsertBefore(ins, insertSentence);

                        //Inserts the callWriteLineMethod after the //insertSentence instruction
                        processor.InsertAfter(insertSentence, callWriteLine);

                    }
                }
            }

            myLibrary.Write("C:/Users/Alex Dzhoganov/Documents/GitHub/KSPLoader/TestLib/bin/Debug/TestLib.dll");
            Console.WriteLine("Assembly succesfully patched");

            for (; ; ) ;
        }
    }
}
