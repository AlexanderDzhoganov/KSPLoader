using System;

namespace KSPLoader
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

            var typeToPatch = outputAssembly.FindTypeByName("", "Wheel");
            var newType = inputAssembly.FindTypeByName("PatchLib", "WheelPatched");
            outputAssembly.SubstituteTypes(typeToPatch, newType);

            outputAssembly.Write("C:/Program Files (x86)/Steam/steamapps/common/Kerbal Space Program/KSP_Data/Managed/Assembly-CSharp.dll");

            Console.WriteLine("Assembly patched");

            for (;;) ;
        }
    }
}
