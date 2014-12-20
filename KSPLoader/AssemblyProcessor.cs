﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public TypeDefinition FindTypeByName(string _namespace, string _type)
        {
            return m_Assembly.MainModule.GetType(_namespace, _type);
        }

        public void SubstituteTypes(TypeDefinition _needle, TypeDefinition _replaceWith)
        {
            SubstituteTypes(m_Assembly.MainModule.Types, _needle, _replaceWith);
        }

        private void SubstituteTypes(ICollection<TypeDefinition> _haystack, TypeDefinition _needle, TypeDefinition _replaceWith)
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
