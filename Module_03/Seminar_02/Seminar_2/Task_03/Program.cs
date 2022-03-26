using System;
using System.Text;

namespace Task_03
{
    // 3_01b #1
    public delegate string ConvertRule(string str);
    public class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr?.Invoke(str);
        }
    }
    class Program
    {
        public static string RemoveDigits(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for (int i = '0'; i <= '9'; i++)
            {
                sb.Replace(((char)i).ToString(), "");
            }
            return sb.ToString();
        }
        public static string RemoveSpaces(string str)
        {
            return str.Replace(" ", "");
        }

        static void Main(string[] args)
        {
            string[] test = { "sgcv1j ang", "qjdbj131j3b 5453 35 6jhb ", "wfk82" };
            Console.WriteLine(String.Join("\n", test));
            var converter = new Converter();
            ConvertRule c1 = RemoveDigits;
            ConvertRule c2 = RemoveSpaces;
            foreach (var t in test)
            {
                Console.WriteLine(converter.Convert(t, c1));
                Console.WriteLine(converter.Convert(t, c2));
            }
            Console.WriteLine();

            ConvertRule convertRule = c1 + c2;
            foreach (var t in test)
            {
                Console.WriteLine(converter.Convert(t, convertRule));
            }
            Console.WriteLine();

            string ans = "";
            foreach (var t in test)
            {
                ans = t;
                foreach (ConvertRule d in convertRule.GetInvocationList())
                    ans = d(ans);
                Console.WriteLine(ans);
            }
        }
    }
}
