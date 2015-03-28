using System;
using System.IO;
using KSPLoader;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace KSPLoaderTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var outPath =
                "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Cities_Skylines\\Cities_Data\\Managed\\Assembly-CSharp.dll";

            var inPath =
                "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Cities_Skylines\\Cities_Data\\Managed\\PatchLib.dll";

            File.Delete(outPath);
            File.Copy("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Cities_Skylines\\Cities_Data\\Managed\\Assembly-CSharp.bak.dll", outPath);

            var outputAssembly = new AssemblyProcessor(outPath);

            var inputAssembly = new AssemblyProcessor(inPath);
/*
            outputAssembly.SubstituteTypes
            (
                outputAssembly.FindTypeByName("", "TreeManager"),
                inputAssembly.FindTypeByName("PatchLib", "TreeManager_v2")
            );
            */

            outputAssembly.SubstituteLiteral(outputAssembly.FindTypeByName("", "TreeManager"), 262144, 262144 * 2);
            outputAssembly.SubstituteLiteral(outputAssembly.FindTypeByName("", "NaturalResourceManager"), 262144, 262144 * 2);
            // outputAssembly.SubstituteLiteral(outputAssembly.FindTypeByName("", "TreeManager"), 250000, 250000 * 2);
            //outputAssembly.SubstituteLiteral(outputAssembly.FindTypeByName("", "TreeManager"), 262139, 262139 * 2);

            outputAssembly.SubstituteLiteral(outputAssembly.FindTypeByName("", "BuildingDecoration"), 262144, 262144 * 2);
            //outputAssembly.SubstituteLiteral(outputAssembly.FindTypeByName("", "BuildingDecoration"), 250000, 250000 * 2);
           // outputAssembly.SubstituteLiteral(outputAssembly.FindTypeByName("", "BuildingDecoration"), 262139, 262139 * 2);

            outputAssembly.Write("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Cities_Skylines\\Cities_Data\\Managed\\Assembly-CSharp.dll");

            Console.WriteLine("Assembly patched");
            for (;;) ;
        }
    }
}
