using System;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace KSPLoader
{
    class TypeProcessor
    {

        public static bool SubstituteGenericInstanceType
        (
            Instruction instruction,
            MethodDefinition method,
            GenericInstanceType genericInstanceType,
            TypeReference needle,
            TypeDefinition replaceWith
        )
        {
            if (genericInstanceType.FullName == needle.FullName)
            {
                instruction.Operand = method.Module.Import(replaceWith);
                Console.WriteLine("Patching InlineMethod: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
                return true;
            }

            bool replacedArg = false;
            for (int i = 0; i < genericInstanceType.GenericArguments.Count; i++)
            {
                if (genericInstanceType.GenericArguments[i].FullName == needle.FullName)
                {
                    genericInstanceType.GenericArguments[i] = method.Module.Import(replaceWith);
                    replacedArg = true;
                }
            }

            return replacedArg;
        }

        public static bool SubstituteTypeReference
        (
            Instruction instruction,
            MethodDefinition method,
            TypeReference typeRef,
            TypeReference needle,
            TypeDefinition replaceWith
        )
        {
            if (typeRef.FullName == needle.FullName)
            {
                instruction.Operand = method.Module.Import(replaceWith);
                Console.WriteLine("Patching InlineMethod: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
                return true;
            }

            if (typeRef.DeclaringType != null)
            {
                if (typeRef.DeclaringType.FullName == needle.FullName)
                {
                    instruction.Operand = method.Module.Import(replaceWith);
                    Console.WriteLine("Patching InlineMethod: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
                    return true;    
                }

                for (int i = 0; i < typeRef.DeclaringType.GenericParameters.Count; i++)
                {
                    if (typeRef.DeclaringType.GenericParameters[i].FullName == needle.FullName)
                    {
                        Console.WriteLine("NOT IMPLEMENTED: typeRef.DeclaringType.GenericParameters[i].FullName == needle.FullName");
                    }
                }
            }

            for (int i = 0; i < typeRef.GenericParameters.Count; i++)
            {
                if (typeRef.GenericParameters[i].FullName == needle.FullName)
                {
                    Console.WriteLine("NOT IMPLEMENTED: typeRef.GenericParameters[i].FullName == needle.FullName");
                }
            }

            return false;
        }

        public static bool SubstituteMethodReference
        (
            Instruction instruction,
            MethodDefinition method,
            MethodReference methodRef,
            TypeReference needle,
            TypeDefinition replaceWith
        )
        {
            bool methodPatched = false;

            if (methodRef.DeclaringType.FullName == needle.FullName)
            {
                foreach (var replaceMethod in replaceWith.Methods)
                {
                    if (replaceMethod.Name == methodRef.Name)
                    {
                        var replaceOperand = method.Module.Import(replaceMethod);
                        instruction.Operand = replaceOperand;

                        Console.WriteLine
                        (
                            "Patching InlineMethod: Replacing {0}::{1} with {2}::{3}",
                            needle.FullName, methodRef.FullName, replaceWith.FullName, replaceMethod.Name
                        );

                        methodPatched = true;
                        break;
                    }
                }
            }
            else if (methodRef.DeclaringType is GenericInstanceType)
            {
                var genericInstanceType = (GenericInstanceType) methodRef.DeclaringType;
                for (int i = 0; i < genericInstanceType.GenericArguments.Count; i++)
                {
                    if (genericInstanceType.GenericArguments[i].FullName == needle.FullName)
                    {
                        genericInstanceType.GenericArguments[i] = method.Module.Import(replaceWith);
                        methodPatched = true;
                    }
                }
            }

            return methodPatched;

        }

        public static bool SubstiteFieldReference
        (
            Instruction instruction,
            MethodDefinition method,
            FieldReference fieldRef,
            TypeReference needle,
            TypeDefinition replaceWith
        )
        {
            if (fieldRef.FullName == needle.FullName)
            {
                instruction.Operand = method.Module.Import(replaceWith);
                Console.WriteLine("Patching InlineField: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
            }
            else if (instruction.Operand is GenericInstanceType)
            {
                Console.WriteLine("NOT IMPLEMENTED: SubstiteFieldReference: instruction.Operand is GenericInstanceType");
            }

            return false;
        }

        public static void ProcessMethod(MethodDefinition method, TypeReference needle, TypeDefinition replaceWith)
        {
            if (method.DeclaringType.FullName == needle.FullName)
            {
                return;
            }

            bool methodPatched = false;

            TypeReference importedReplaceWith = method.Module.Import(replaceWith); 

            if (method.HasBody)
            {
                Mono.Collections.Generic.Collection<Instruction> instructions = method.Body.Instructions;

                if (method.ReturnType.FullName == needle.FullName)
                {
                    method.ReturnType = importedReplaceWith;
                    Console.WriteLine("Patching return type: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
                    methodPatched = true;
                }
                else if (method.ReturnType.DeclaringType != null &&
                    method.ReturnType.DeclaringType.FullName == needle.FullName)
                {
                    Console.WriteLine("NOT IMPLEMENTED: ProcessMethod: method.ReturnType.DeclaringType == needle");
                }

                for (int i = 0; i < method.Parameters.Count; i++)
                {
                    if (method.Parameters[i].ParameterType.FullName == needle.FullName)
                    {
                        method.Parameters[i].ParameterType = importedReplaceWith;
                        Console.WriteLine("Patching parameter type: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
                    }
                    else if (method.Parameters[i].ParameterType.DeclaringType != null &&
                        method.Parameters[i].ParameterType.DeclaringType.FullName == needle.FullName)
                    {
                        Console.WriteLine("NOT IMPLEMENTED: ProcessMethod: method.Parameters[i].ParameterType.DeclaringType == needle");
                    }
                }

                for (int i = 0; i < method.GenericParameters.Count; i++)
                {
                    if (method.GenericParameters[i].DeclaringType != null &&
                        method.GenericParameters[i].DeclaringType.FullName == needle.FullName)
                    {
                        Console.WriteLine("NOT IMPLEMENTED: ProcessMethod: method.GenericParameters[i].DeclaringType == needle");
                    }
                }

                for (int i = 0; i < method.Body.Variables.Count; i++)
                {
                    if (method.Body.Variables[i].VariableType.FullName == needle.FullName)
                    {
                        method.Body.Variables[i].VariableType = importedReplaceWith;
                        Console.WriteLine("Patching local variable: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
                        methodPatched = true;
                    }

                    if (method.Body.Variables[i].VariableType.DeclaringType != null && 
                        method.Body.Variables[i].VariableType.DeclaringType.HasGenericParameters)
                    {
                        var genericInstanceType = (GenericInstanceType) method.Body.Variables[i].VariableType;
                        for (int q = 0; q < genericInstanceType.GenericArguments.Count; q++)
                        {
                            if (genericInstanceType.GenericArguments[q].FullName == needle.FullName)
                            {
                                genericInstanceType.GenericArguments[q] = importedReplaceWith;
                                methodPatched = true;
                            }
                        }
                    }
                }

                for (int i = 0; i < instructions.Count; i++)
                {
                    Instruction instruction = instructions[i];
                    var operandType = instruction.OpCode.OperandType;

                    if (operandType == OperandType.InlineArg) 
                    {
                        var parameterDef = (ParameterDefinition)instruction.Operand;
                        if (parameterDef.ParameterType.FullName == needle.FullName)
                        {
                            parameterDef.ParameterType = importedReplaceWith;
                            methodPatched = true;
                        }
                        else if (parameterDef.ParameterType.DeclaringType != null &&
                            parameterDef.ParameterType.DeclaringType.FullName == needle.FullName)
                        {
                            parameterDef.ParameterType.DeclaringType = importedReplaceWith;
                            methodPatched = true;
                        }
                    }
                    else if (operandType == OperandType.InlineBrTarget) {}
                    else if (operandType == OperandType.InlineField)
                    {
                        var fieldRef = (FieldReference)instruction.Operand;
                        if (fieldRef.FieldType is GenericInstanceType)
                        {
                            var genericInstanceType = (GenericInstanceType)fieldRef.FieldType;
                            if (SubstituteGenericInstanceType(instruction, method, genericInstanceType, needle, replaceWith))
                            {
                                methodPatched = true;
                            }
                        }
                        else
                        {
                            if (SubstiteFieldReference(instruction, method, fieldRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }
                        }
                    }
                    else if (operandType == OperandType.InlineI) {}
                    else if (operandType == OperandType.InlineI8) {}
                    else if (operandType == OperandType.InlineMethod)
                    {
                        var methodRef = (MethodReference)instruction.Operand;
                        if (SubstituteMethodReference(instruction, method, methodRef, needle, replaceWith))
                        {
                            methodPatched = true;
                        }
                    }
                    else if (operandType == OperandType.InlineNone) {}
                    else if (operandType == OperandType.InlinePhi) {}
                    else if (operandType == OperandType.InlineR) {}
                    else if (operandType == OperandType.InlineSig) {}
                    else if (operandType == OperandType.InlineString) {}
                    else if (operandType == OperandType.InlineSwitch) {}
                    else if (operandType == OperandType.InlineTok)
                    {
                        var type = instruction.Operand.GetType();
                        if (type.Name == "MethodDefinition")
                        {
                            var methodRef = (MethodReference)instruction.Operand;

                            if (SubstituteMethodReference(instruction, method, methodRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }
                        }
                        else if(type.Name == "FieldDefinition")
                        {
                            var fieldRef = (FieldReference)instruction.Operand;
                            if (SubstiteFieldReference(instruction, method, fieldRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }
                        }
                        else if (type.Name == "PropertyDefinition")
                        {
                            Console.WriteLine("NOT IMPLEMENTED: ProcessMethod else if (type.Name == \"PropertyDefinition\")");
                        }
                        else if (type.Name == "TypeDefinition")
                        {
                            var typeRef = (TypeReference)instruction.Operand;
                            if (SubstituteTypeReference(instruction, method, typeRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }
                        }
                    }
                    else if (operandType == OperandType.InlineType)
                    {
                        if (instruction.Operand is GenericInstanceType)
                        {
                            var genericInstanceType = (GenericInstanceType)instruction.Operand;
                            if (SubstituteGenericInstanceType(instruction, method, genericInstanceType, needle, replaceWith))
                            {
                                methodPatched = true;
                            } 
                        }
                        else if (instruction.Operand is TypeReference)
                        {
                            var typeRef = (TypeReference)instruction.Operand;
                            if (SubstituteTypeReference(instruction, method, typeRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }  
                        }
                    }
                    else if (operandType == OperandType.InlineVar)
                    {
                        var variableDef = (VariableDefinition) instruction.Operand;
                        if (variableDef.VariableType.FullName == needle.FullName)
                        {
                            variableDef.VariableType = importedReplaceWith;
                            methodPatched = true;
                        }
                        else if (variableDef.VariableType.DeclaringType != null &&
                            variableDef.VariableType.DeclaringType.FullName == needle.FullName)
                        {
                            variableDef.VariableType.DeclaringType = importedReplaceWith;
                            methodPatched = true;
                        }
                    }
                    else if (operandType == OperandType.ShortInlineArg)
                    {
                        var parameterDef = (ParameterDefinition)instruction.Operand;
                        if (parameterDef.ParameterType.FullName == needle.FullName)
                        {
                            parameterDef.ParameterType = importedReplaceWith;
                            methodPatched = true;
                        }
                        else if (parameterDef.ParameterType.DeclaringType != null &&
                            parameterDef.ParameterType.DeclaringType.FullName == needle.FullName)
                        {
                            parameterDef.ParameterType.DeclaringType = importedReplaceWith;
                            methodPatched = true;
                        }
                    }
                    else if (operandType == OperandType.ShortInlineBrTarget) {}
                    else if (operandType == OperandType.ShortInlineI) {}
                    else if (operandType == OperandType.ShortInlineR) {}
                    else if (operandType == OperandType.ShortInlineVar)
                    {
                        var variableDef = (VariableDefinition)instruction.Operand;
                        if (variableDef.VariableType.FullName == needle.FullName)
                        {
                            variableDef.VariableType = importedReplaceWith;
                            methodPatched = true;
                        }
                        else if (variableDef.VariableType.DeclaringType != null &&
                            variableDef.VariableType.DeclaringType.FullName == needle.FullName)
                        {
                            variableDef.VariableType.DeclaringType = importedReplaceWith;
                            methodPatched = true;
                        }
                    }
                }   
            }

            if (methodPatched)
            {
                Console.WriteLine("Patched method {0}", method.FullName);
            }
        }

        public static void ProcessField(FieldDefinition field, TypeReference needle, TypeDefinition replaceWith)
        {
            if (field.FieldType.FullName == needle.FullName)
            {
                field.FieldType = needle;
                Console.WriteLine("Patched Field: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
            }
            else if (field.FieldType.DeclaringType != null)
            {
                if (field.FieldType.DeclaringType.FullName == needle.FullName)
                {
                    Console.WriteLine("NOT IMPLEMENTED: ProcessField: field.FieldType.DeclaringType.FullName == needle.FullName");
                }
            }
            else if (field.FieldType is GenericInstanceType)
            {
                var genericInstanceType = (GenericInstanceType)field.FieldType;
                for (int i = 0; i < genericInstanceType.GenericArguments.Count; i++)
                {
                    if (genericInstanceType.GenericArguments[i].FullName == needle.FullName)
                    {
                        genericInstanceType.GenericArguments[i] = field.Module.Import(replaceWith);
                    }
                }
            }
        }

        public static void ProcessProperty(PropertyDefinition property, TypeReference needle, TypeDefinition replaceWith)
        {
            if (property.PropertyType.FullName == needle.FullName)
            {
                property.PropertyType = needle;
                Console.WriteLine("Patched Property: Replacing {0} with {1}", needle.FullName, replaceWith.FullName);
            }
            else if (property.PropertyType.DeclaringType != null &&
                property.PropertyType.DeclaringType.FullName == needle.FullName)
            {
                Console.WriteLine("NOT IMPLEMENTED: ProcessProperty: property.PropertyType.DeclaringType.FullName == needle.FullName");
            }
            else if (property.PropertyType is GenericInstanceType)
            {
                var genericInstanceType = (GenericInstanceType)property.PropertyType;
                for (int i = 0; i < genericInstanceType.GenericArguments.Count; i++)
                {
                    if (genericInstanceType.GenericArguments[i].FullName == needle.FullName)
                    {
                        genericInstanceType.GenericArguments[i] = property.Module.Import(replaceWith);
                    }
                }
            }
        }

    }
}
