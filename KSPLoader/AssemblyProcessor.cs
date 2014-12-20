using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;

namespace KSPLoader
{

    public class AssemblyProcessor
    {

        public AssemblyProcessor(string assemblyPath)
        {
            m_Assembly = AssemblyDefinition.ReadAssembly(assemblyPath);
        }

        public void Write(string path)
        {
            m_Assembly.Write(path);
        }

        public bool Tag(string _namespace, string _type, Type _replaceWith)
        {
            var findType = m_Assembly.MainModule.GetType(_namespace, _type);
            if (findType == null)
            {
                Console.WriteLine("Error, could not find type RnDBuilding in Assembly-CSharp");
                return false;
            }

            var replaceType = m_Assembly.MainModule.Import(_replaceWith).Resolve();

            Console.WriteLine("Replacing all references to {0} with {1}", findType.FullName, _replaceWith.FullName);
            Tag(m_Assembly.MainModule.Types, findType, replaceType);

            return true;
        }

        private void Tag(ICollection<TypeDefinition> _haystack, TypeDefinition _needle, TypeDefinition _replaceWith)
        {
            foreach (var typeDef in _haystack)
            {
                if (typeDef.Name == _needle.Name)
                {
                    continue;
                }

                foreach (var methodDef in typeDef.Methods)
                {
                    TypeProcessor.ProcessMethod(methodDef, _needle, _replaceWith);
                }

                foreach (var fieldDef in typeDef.Fields)
                {
                    TypeProcessor.ProcessField(fieldDef, _needle, _replaceWith);
                }

                foreach (var propertyDef in typeDef.Properties)
                {
                    TypeProcessor.ProcessProperty(propertyDef, _needle, _replaceWith);
                }
            }
        }

        private readonly AssemblyDefinition m_Assembly = null;

    }


}
