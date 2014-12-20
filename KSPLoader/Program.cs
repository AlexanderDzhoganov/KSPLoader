using System;

namespace KSPLoader
{
    class Program
    {

        static void Main(string[] args)
        {
            var assemblyProcessor =
                new AssemblyProcessor(
                    "C:/Program Files (x86)/Steam/steamapps/common/Kerbal Space Program/KSP_Data/Managed/Assembly-CSharp.dll.original");

            var result = assemblyProcessor.Tag("", "Wheel", typeof(PatchLib.WheelPatched));
            assemblyProcessor.Write("C:/Program Files (x86)/Steam/steamapps/common/Kerbal Space Program/KSP_Data/Managed/Assembly-CSharp.dll");

            if (result)
            {
                Console.WriteLine("Assembly succesfully patched");
            }
            else
            {
                Console.WriteLine("Failed to patch assembly");
            }
            for (;;) ;
        }
    }
}
