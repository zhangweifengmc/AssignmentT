using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentTDome
{
    public static class StringExtension
    {
        public static bool IsMatch(this string input, string pattern, RegexOptions options = RegexOptions.None)
        {
            return Regex.IsMatch(input, pattern, options);
        }

        public static bool IsNumber(this string input)
        {
            return Regex.IsMatch(input, @"(^[-]{0,1}[0-9]+$)|(^[-]{0,1}[0-9]+[\.]{1}[0-9]+$)");
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static string Join(this IEnumerable<string> values, string separator)
        {
            return string.Join(separator, values);
        }

        public static string[] Split(this string value, string separator)
        {
            return value.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static List<string> SplitList(this string value, string separator)
        {
            return Split(value, separator).ToList();
        }

        public static int ToInt32(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static long ToInt64(this string value)
        {
            return Convert.ToInt64(value);
        }

        public static float ToFloat(this string value)
        {
            return float.Parse(value);
        }

        public static double ToDouble(this string value)
        {
            return Convert.ToDouble(value);
        }

        public static decimal ToDecimal(this string value)
        {
            return Convert.ToDecimal(value);
        }

        public static DateTime ToDateTime(this string value)
        {
            return Convert.ToDateTime(value);
        }

        public static DateTimeOffset ToDateTimeOffset(this string value)
        {
            return DateTimeOffset.Parse(value);
        }

        /// <summary>
        /// 国际化（未实现）
        /// </summary>
        /// <param name="key">标签键</param>
        /// <returns></returns>
        public static string I18N(this string key)
        {
            return key;
        }

        /// <summary>
        /// 把str转为bool类型
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool StringFormat(string str)
        {
            bool result = false;
            if (str == "1" || str.ToLower() == "true")
                return result = true;
            else if (str == "0")
                return result = false;
            return result;
        }

        /// <summary>
        /// 字符串转int 转换失败返回0
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defaultResult">转换失败返回的默认值</param>
        /// <returns></returns>
        public static int StringConvertToInt(string str, int defaultResult = 0)
        {
            int result = 0;
            if (int.TryParse(str, out result))
            {
                return result;
            }
            return defaultResult;
        }

        public static byte[] GetBytes(this string value, Encoding encoding)
        {
            return encoding.GetBytes(value);
        }

        public static byte[] GetBytes(this string value)
        {
            return GetBytes(value, Encoding.UTF8);
        }

        public static int GetByteLength(this string value, Encoding encoding)
        {
            return encoding.GetByteCount(value);
        }

        public static int GetByteLength(this string value)
        {
            return GetByteLength(value, Encoding.UTF8);
        }
    }
}
