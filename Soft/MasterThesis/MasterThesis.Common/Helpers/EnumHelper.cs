using System;
using System.ComponentModel;
using System.Reflection;

namespace MasterThesis.Common.Helpers
{
    public static class EnumHelper
    {
        public static bool TryGetEnumValueFromDescription<T>(string description, out T result)
        {
            MemberInfo[] fis = typeof(T).GetFields();

            foreach (var fi in fis)
            {
                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0 && attributes[0].Description == description)
                {
                    result = (T)Enum.Parse(typeof(T), fi.Name);
                    return true;
                }
            }

            result = default(T);
            return false;
        }

        public static string GetEnumDescription<T>(this T value)
        {
            Type type = typeof(T);

            MemberInfo[] memInfo = type.GetMember(value.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return value.ToString();
        }
    }
}
