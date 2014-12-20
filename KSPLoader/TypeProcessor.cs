using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace KSPLoader
{
    class TypeProcessor
    {

        public static bool ProcessGenericInstanceType
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

        public static bool ProcessInlineType
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

        public static bool ProcessInlineMethod
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
                bool methodFound = false;

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
                        methodFound = true;
                        break;
                    }
                }

                if (!methodFound)
                {
                    Console.WriteLine("CRITICAL ERROR: Function {0} not found in replacement class {1}", methodRef.FullName, replaceWith.FullName);
                }
            }

            return methodPatched;

        }

        public static bool ProcessInlineField
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

            return false;
        }

        public static void ProcessMethod(MethodDefinition method, TypeReference needle, TypeDefinition replaceWith)
        {
            if (method.Name == "SetupWheel")
            {
                int p = 0;
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
                    Console.WriteLine("NOT IMPLEMENTED: method.ReturnType.DeclaringType == needle");
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
                        Console.WriteLine("NOT IMPLEMENTED: method.Parameters[i].ParameterType.DeclaringType == needle");
                    }
                }

                for (int i = 0; i < method.GenericParameters.Count; i++)
                {
                    if (method.GenericParameters[i].DeclaringType != null &&
                        method.GenericParameters[i].DeclaringType.FullName == needle.FullName)
                    {
                        Console.WriteLine("NOT IMPLEMENTED: method.GenericParameters[i].DeclaringType == needle");
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
                    else if (method.Body.Variables[i].VariableType.DeclaringType != null &&
                        method.Body.Variables[i].VariableType.DeclaringType.FullName == needle.FullName)
                    {
                        Console.WriteLine("NOT IMPLEMENTED: method.Body.Variables[i].VariableType.DeclaringType == needle");
                    }
                }

                if (method.Body.Scope != null)
                {
                    for (int i = 0; i < method.Body.Scope.Variables.Count; i++)
                    {
                        int q = 0;
                    }
                }

                for (int i = 0; i < instructions.Count; i++)
                {
                    Instruction instruction = instructions[i];
                    var operandType = instruction.OpCode.OperandType;

                    if (operandType == OperandType.InlineType)
                    {
                        if (instruction.Operand is GenericInstanceType)
                        {
                            var genericInstanceType = (GenericInstanceType)instruction.Operand;
                            if (ProcessGenericInstanceType(instruction, method, genericInstanceType, needle, replaceWith))
                            {
                                methodPatched = true;
                            } 
                        }
                        else if (instruction.Operand is TypeReference)
                        {
                            var typeRef = (TypeReference)instruction.Operand;
                            if (ProcessInlineType(instruction, method, typeRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }  
                        }
                    }
                    else if (operandType == OperandType.InlineTok)
                    {
                        var type = instruction.Operand.GetType();
                        if (type.Name == "MethodDefinition")
                        {
                            var methodRef = (MethodReference)instruction.Operand;

                            if (ProcessInlineMethod(instruction, method, methodRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }
                        }
                        else if(type.Name == "FieldDefinition")
                        {
                            var fieldRef = (FieldReference)instruction.Operand;
                            if (ProcessInlineField(instruction, method, fieldRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }
                        }
                        else if (type.Name == "PropertyDefinition")
                        {
                            Console.WriteLine("NOT IMPLEMENTED: else if (type.Name == \"PropertyDefinition\")");
                        }
                        else if (type.Name == "TypeDefinition")
                        {
                            var typeRef = (TypeReference)instruction.Operand;
                            if (ProcessInlineType(instruction, method, typeRef, needle, replaceWith))
                            {
                                methodPatched = true;
                            }
                        }
                    }
                    else if (operandType == OperandType.InlineMethod)
                    {
                        var methodRef = (MethodReference)instruction.Operand;
                        if (ProcessInlineMethod(instruction, method, methodRef, needle, replaceWith))
                        {
                            methodPatched = true;
                        }
                    }
                    else if (operandType == OperandType.InlineField)
                    {
                        var fieldRef = (FieldReference) instruction.Operand;
                        if (ProcessInlineField(instruction, method, fieldRef, needle, replaceWith))
                        {
                            methodPatched = true;
                        }
                    }
                    else if (operandType == OperandType.ShortInlineVar)
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
                    else if (operandType == OperandType.InlineArg)
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
                    else if (operandType == OperandType.InlineSig)
                    {
                    }
                    else if (operandType == OperandType.InlineNone)
                    {
                    }
                    else if (operandType == OperandType.InlineI)
                    {
                    }
                    else if (operandType == OperandType.InlineI8)
                    {
                    }
                    else if (operandType == OperandType.ShortInlineI)
                    {
                    }
                    else if (operandType == OperandType.InlineR)
                    {
                    }
                    else if (operandType == OperandType.ShortInlineR)
                    {
                    }                    
                    else if (operandType == OperandType.ShortInlineBrTarget)
                    {
                    }
                    else if (operandType == OperandType.InlineBrTarget)
                    {
                    }
                    else if (operandType == OperandType.InlineSwitch)
                    {
                    }
                    else
                    {
                        Console.WriteLine("NOT IMPLEMENTED: operandType == {0}", operandType);
                    }
                }   
            }

            if (methodPatched)
            {
                Console.WriteLine("##### Patched method {0} #####", method.FullName);
            }
        }

        public static void ProcessField(FieldDefinition field, TypeReference needle, TypeDefinition replaceWith)
        {
            if (field.FieldType.FullName == needle.FullName)
            {
                field.FieldType = needle;
                Console.WriteLine("### Patched Field: Replacing {0} with {1} ###", needle.FullName, replaceWith.FullName);
            }
            else if (field.FieldType.DeclaringType != null && 
                field.FieldType.DeclaringType.FullName == needle.FullName)
            {
                Console.WriteLine("NOT IMPLEMENTED: field.FieldType.DeclaringType.FullName == needle.FullName");
            }
        }

        public static void ProcessProperty(PropertyDefinition property, TypeReference needle, TypeDefinition replaceWith)
        {
            if (property.PropertyType.FullName == needle.FullName)
            {
                property.PropertyType = needle;
                Console.WriteLine("### Patched Property: Replacing {0} with {1} ###", needle.FullName, replaceWith.FullName);
            }
            else if (property.PropertyType.DeclaringType != null &&
                property.PropertyType.DeclaringType.FullName == needle.FullName)
            {
                Console.WriteLine("NOT IMPLEMENTED: property.PropertyType.DeclaringType.FullName == needle.FullName");
            }
        }

    }
}
