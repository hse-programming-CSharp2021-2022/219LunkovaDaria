using System;
using System.Text;

namespace Task_01
{
    class Program
    {
        public static string Abbriviation(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            string result = String.Empty;
            string abbr = String.Empty;
            if (str != String.Empty)
            {
                string[] words = str.Split(' ');
                foreach (string word in words)
                {
                    abbr = word.Substring(0, word.ToLower().IndexOfAny(vowels));
                    //здесь что-то не то
                    abbr = abbr[0].ToString().ToUpper() + abbr.Substring(1);
                }
            }
            
            return abbr;
        }
        
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strs = str.Split(';');
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(Abbriviation(strs[i]));
            }
        }
    }
}
