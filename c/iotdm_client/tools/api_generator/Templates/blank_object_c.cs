﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace api_generator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class blank_object_c : blank_object_cBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            
            #line 7 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
 
var allProps = Program.GetListOfPropertiesToGenerate(ObjectName); 

            
            #line default
            #line hidden
            this.Write("\r\n// Copyright (c) Microsoft. All rights reserved.\r\n// Licensed under the MIT lic" +
                    "ense. See LICENSE file in the project root for full license information.\r\n\r\n//\r\n" +
                    "// Simple implementation of IoTHub LWM2M ");
            
            #line 15 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectName));
            
            #line default
            #line hidden
            this.Write(" object\r\n//\r\n\r\n//     This code was generated by a tool.\r\n//\r\n//     Changes to t" +
                    "his file may cause incorrect behavior and will be lost if\r\n//     the code is re" +
                    "generated.\r\n\r\n#include \"iotdm_internal.h\"\r\n#include \"iotdm_dispatchers.h\"\r\n#incl" +
                    "ude \"");
            
            #line 25 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_object.h\"\r\n\r\n\r\n/****************************************************************" +
                    "******************\r\n * ");
            
            #line 29 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectName));
            
            #line default
            #line hidden
            this.Write(" default property values\r\n *\r\n **************************************************" +
                    "********************************/\r\n\r\nvoid set_default_");
            
            #line 33 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectCodeName));
            
            #line default
            #line hidden
            this.Write("_property_values(");
            
            #line 33 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ObjectStructName));
            
            #line default
            #line hidden
            this.Write(" *obj)\r\n{\r\n");
            
            #line 35 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

    foreach (var prop in allProps)
    {
        if (prop.CanRead)
        {

            
            #line default
            #line hidden
            this.Write("    set_");
            
            #line 41 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("(obj->instanceId, ");
            
            #line 41 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDefaultValue(prop, false)));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 42 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

        }
        else if (prop.CanWrite)
        {

            
            #line default
            #line hidden
            this.Write("    obj->");
            
            #line 47 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 47 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDefaultValue(prop, true)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 48 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("}\r\n\r\n/***************************************************************************" +
                    "*******\r\n * CALLBACK HANDLERS\r\n *\r\n ********************************************" +
                    "**************************************/\r\n");
            
            #line 58 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

    foreach (var prop in allProps)
    {
        if (prop.CanRead)
        { 

            
            #line default
            #line hidden
            
            #line 64 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetReadPrototype(prop)));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    IOTHUB_CLIENT_RESULT result = IOTHUB_CLIENT_OK;\r\n    if (obj->");
            
            #line 67 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_read_callback != NULL)\r\n    {\r\n        result = obj->");
            
            #line 69 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_read_callback(obj);\r\n    }\r\n    if (result == IOTHUB_CLIENT_OK)\r\n    {\r\n");
            
            #line 73 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

            switch (prop.ResourceFromXml.Type)
            {
                case LWM2MObjectItemType.String:

            
            #line default
            #line hidden
            this.Write("        *value = lwm2m_strdup(obj->");
            
            #line 78 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(");\r\n        LogInfo(\"returning [%s] for ");
            
            #line 79 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write("\\r\\n\", *value);\r\n");
            
            #line 80 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

                    break;
                case LWM2MObjectItemType.Float:

            
            #line default
            #line hidden
            this.Write("        *value = obj->");
            
            #line 84 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(";\r\n        LogInfo(\"returning %f for ");
            
            #line 85 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write("\\r\\n\", *value);\r\n");
            
            #line 86 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

                    break;
                case LWM2MObjectItemType.Integer:
                case LWM2MObjectItemType.Time:

            
            #line default
            #line hidden
            this.Write("        *value = obj->");
            
            #line 91 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(";\r\n        LogInfo(\"returning %d for ");
            
            #line 92 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write("\\r\\n\", *value);\r\n");
            
            #line 93 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

                    break;
                }

            
            #line default
            #line hidden
            this.Write("    }\r\n    return result;\r\n}\r\n\r\n");
            
            #line 101 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

            }
            if (prop.CanWrite)
            { 

            
            #line default
            #line hidden
            
            #line 106 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetWritePrototype(prop)));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 108 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

                switch (prop.ResourceFromXml.Type)
                {
                    case LWM2MObjectItemType.Opaque:

            
            #line default
            #line hidden
            this.Write("\r\n    return IOTHUB_CLIENT_NOT_IMPLEMENTED;\r\n");
            
            #line 115 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

                        break;
                    case LWM2MObjectItemType.String:

            
            #line default
            #line hidden
            this.Write("    IOTHUB_CLIENT_RESULT result = IOTHUB_CLIENT_OK;\r\n    LogInfo(\"");
            
            #line 120 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write(" being set to [%s]\\r\\n\", value);\r\n    lwm2m_free(obj->");
            
            #line 121 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(");\r\n    obj->");
            
            #line 122 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(" = lwm2m_strdup(value);\r\n\r\n    if (obj->");
            
            #line 124 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_write_callback != NULL)\r\n    {\r\n        result = obj->");
            
            #line 126 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_write_callback(obj);\r\n    }\r\n    return result;\r\n");
            
            #line 129 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

                    break;
                case LWM2MObjectItemType.Float:

            
            #line default
            #line hidden
            this.Write("    IOTHUB_CLIENT_RESULT result = IOTHUB_CLIENT_OK;\r\n    LogInfo(\"");
            
            #line 134 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write(" being set to %f\\r\\n\", value);\r\n    (obj->");
            
            #line 135 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n\r\n    if (obj->");
            
            #line 137 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_write_callback != NULL)\r\n    {\r\n        result = obj->");
            
            #line 139 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_write_callback(obj);\r\n    }\r\n    return result;\r\n");
            
            #line 142 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

                    break;
                case LWM2MObjectItemType.Integer:
                case LWM2MObjectItemType.Time:

            
            #line default
            #line hidden
            this.Write("    IOTHUB_CLIENT_RESULT result = IOTHUB_CLIENT_OK;\r\n    LogInfo(\"");
            
            #line 148 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write(" being set to to %d\\r\\n\", value);\r\n    obj->");
            
            #line 149 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.SampleVariableName));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n\r\n    if (obj->");
            
            #line 151 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_write_callback != NULL)\r\n    {\r\n        result = obj->");
            
            #line 153 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_write_callback(obj);\r\n    }\r\n    return result;\r\n");
            
            #line 156 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

                    break;
            }

            
            #line default
            #line hidden
            this.Write("}\r\n\r\n");
            
            #line 162 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

        }
        if (prop.CanExecute)
        { 

            
            #line default
            #line hidden
            
            #line 167 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetExecutePrototype(prop)));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    IOTHUB_CLIENT_RESULT result = IOTHUB_CLIENT_NOT_IMPLEMENTED;\r\n    LogInf" +
                    "o(\"inside execute handler for ");
            
            #line 170 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName));
            
            #line default
            #line hidden
            this.Write("\\r\\n\");\r\n    if (obj->");
            
            #line 171 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_execute_callback != NULL)\r\n    {\r\n        result = obj->");
            
            #line 173 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PropertyName.ToLower()));
            
            #line default
            #line hidden
            this.Write("_execute_callback(obj);\r\n    }\r\n    return result;\r\n}\r\n\r\n");
            
            #line 178 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 183 "H:\repos\Azure-Iot-Sdks-OneBranch\c\iotdm_client\tools\api_generator\Templates\blank_object_c.tt"
 

public string ObjectName;

public uint ObjectId;

public int PropertyCount;

public string ObjectCodeName
{
    get
    {
        return ObjectName.Replace(" ","").ToLower();
    }
}

public string ObjectStructName
{
    get
    {
        return "object_" + ObjectCodeName;
    }
}

private string GetReadPrototype(PropertyToGenerate prop)
{
    if (prop.Type == LWM2MObjectItemType.Opaque)
    {
        return "IOTHUB_CLIENT_RESULT on_read_" + prop.PropertyName.ToLower() + "(" + ObjectStructName + " *obj, void **value, size_t *length)";
    }
    else if (prop.Type == LWM2MObjectItemType.String)
    {
        return "IOTHUB_CLIENT_RESULT on_read_" + prop.PropertyName.ToLower() + "(" + ObjectStructName + " *obj, char **value)";
    }
    else
    {
        return "IOTHUB_CLIENT_RESULT on_read_" + prop.PropertyName.ToLower() + "(" + ObjectStructName + " *obj, " + prop.PropertyTypeCodeName + " *value)";
    }
}

private string GetWritePrototype(PropertyToGenerate prop)
{
    if (prop.Type == LWM2MObjectItemType.Opaque)
    {
        return "IOTHUB_CLIENT_RESULT on_write_" + prop.PropertyName.ToLower() + "(" + ObjectStructName + " *obj, " + prop.PropertyTypeCodeName + " value, size_t length)";
    }
    else
    {
        return "IOTHUB_CLIENT_RESULT on_write_" + prop.PropertyName.ToLower() + "(" + ObjectStructName + " *obj, " + prop.PropertyTypeCodeName + " value)";
    }
}

private string GetSetterPrototype(PropertyToGenerate prop)
{
// BKTODO: should this return result or void?
    if (prop.Type == LWM2MObjectItemType.Opaque)
    {
        return "IOTHUB_CLIENT_RESULT set_" + prop.PropertyName.ToLower() + "(uint16_t instanceId, " + prop.PropertyTypeCodeName + " value, size_t length)";
    }
    else
    {
        return "IOTHUB_CLIENT_RESULT set_" + prop.PropertyName.ToLower() + "(uint16_t instanceId, " + prop.PropertyTypeCodeName + " value)";
    }
}


private string GetExecutePrototype(PropertyToGenerate prop)
{
    return "IOTHUB_CLIENT_RESULT on_exec_" + prop.PropertyName.ToLower() + "("  + ObjectStructName + " *obj)";
}

private string GetDefaultValue(PropertyToGenerate prop, bool addStrdup)
{
    switch (prop.Type)
    {
        case LWM2MObjectItemType.String:
            if (addStrdup)
            {
                return "lwm2m_strdup(\"\")";
            }
            else
            {
                return "\"" + prop.PropertyName + "\"";
            }
        case LWM2MObjectItemType.Boolean:
            return "false";
        case LWM2MObjectItemType.Float:
            return "-1.0";
        case LWM2MObjectItemType.Integer:
        case LWM2MObjectItemType.Time:
            return "-1";
        default:
            return "NULL";
    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class blank_object_cBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
