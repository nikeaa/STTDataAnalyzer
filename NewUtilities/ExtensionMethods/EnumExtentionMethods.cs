using System;
using System.Collections.Generic;
using System.Reflection;
using STTDataAnalyser.Utilities.Attributes;

namespace STTDataAnalyser.Utilities.ExtensionMethods
{
    public static class EnumExtensionMethods
    {
        public static string GetStringValue(this Enum value)
        {
            Type type = value.GetType();

           FieldInfo fieldInfo = type.GetField(value.ToString());

            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            return attribs.Length > 0 ? attribs[0].StringValue : null;
        }

        //public static List<string> GetStringValueList(this Enum value)
        //{
        //    List<string> result = new List<string>();
        //    Type enumType = value.GetType();

        //    foreach (object item in Enum.GetValues(enumType))
        //    {
        //        if (value.GetStringValue() != null)
        //        {
        //            result.Add(value.GetStringValue());
        //        }
        //        else
        //        {
        //            result.Add(value.ToString());
        //        }
        //    }

        //    return result;
        //}
    }
}
