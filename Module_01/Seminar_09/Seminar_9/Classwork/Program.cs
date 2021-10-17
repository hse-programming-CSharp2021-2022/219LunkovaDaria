using System;
using System.Text;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str = "abc";
            string str2 = string.Empty;
            StringBuilder sb = new StringBuilder("ABC", 50);

            string str3 = new string(new char[] { 'a', 'b', 'c' }, 1, 1);
            Console.WriteLine(str3);

            string str4 = new string('a', 10);
            Console.WriteLine(str4);

            string str5 = string.Concat(str4, str3);
            Console.WriteLine(str5);

            Console.WriteLine(str3.Contains("b"));

            string[] strs = new string[] { "aaa", "bbb", "ccc" };
            Console.WriteLine(string.Join(',', strs));
        }
    }
}
