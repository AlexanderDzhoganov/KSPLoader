using System;
using KSPLoader;

namespace KSPLoaderTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var outputAssembly =
                new AssemblyProcessor(
                    "C:/Program Files (x86)/Steam/steamapps/common/Kerbal Space Program/KSP_Data/Managed/Assembly-CSharp.original.dll");

            var inputAssembly =
                new AssemblyProcessor(
                    "C:/Program Files (x86)/Steam/steamapps/common/Kerbal Space Program/KSP_Data/Managed/PatchLib.dll");

            outputAssembly.SubstituteTypes
            (
                outputAssembly.FindTypeByName("", "CrewGenerator"), 
                inputAssembly.FindTypeByName("PatchLib", "CrewGenerator_v2")
            );

            outputAssembly.Write("C:/Program Files (x86)/Steam/steamapps/common/Kerbal Space Program/KSP_Data/Managed/Assembly-CSharp.dll");

            Console.WriteLine("Assembly patched");
        }
    }
}
