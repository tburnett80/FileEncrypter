using System;
using System.Linq;
using System.Text;

namespace FrontEnd
{
    public static class ExtensionMethods
    {
        public static string TryTrim(this string value)
        {
            return !string.IsNullOrEmpty(value)
                ? value.Trim()
                : string.Empty;
        }

        public static byte[] ToBytes(this string value)
        {
            return !string.IsNullOrEmpty(value.TryTrim())
                ? Encoding.UTF8.GetBytes(value.TryTrim())
                : new byte[0];
        }

        public static string FromBytes(this byte[] value)
        {
            return value != null && value.Any()
                ? Encoding.UTF8.GetString(value)
                : string.Empty;
        }

        public static string ToBase64(this byte[] value)
        {
            return value != null && value.Any() 
                ? Convert.ToBase64String(value)
                : string.Empty;
        }

        public static byte[] FromBase64(this string value)
        {
            return !string.IsNullOrEmpty(value.TryTrim())
                ? Convert.FromBase64String(value)
                : new byte[0];
        }
    }
}
