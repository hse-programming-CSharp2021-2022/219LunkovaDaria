using System;
using System.IO;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            try
            {
                int a = 0;
                int f = 5 / a;
            }
            catch (DivideByZeroException e1) { Console.WriteLine("1. " + e1.Message); }
            
            // 2.
            try
            {
                string[] str2 = new string[2];
                str2[5] += "o";
            }
            catch (IndexOutOfRangeException e2) { Console.WriteLine("2. " + e2.Message); }
            
            // 3.
            try
            {
                string[] str3 = { null };
                Console.WriteLine("{0}", str3[0].Trim());
            }
            catch (NullReferenceException e3) { Console.WriteLine("3. " + e3.Message); }
            
            // 4.
            try
            {
                string[] str4 = { "hdbjvhj" };
                int x = int.Parse(str4[0]);
            }
            catch (FormatException e4) { Console.WriteLine("4. " + e4.Message); }

            // 5.
            try
            {
                char a = 'a';
                DateTime dt = Convert.ToDateTime(a);
            }
            catch (InvalidCastException e5) { Console.WriteLine("5. " + e5.Message); }

            // 6.
            checked
            {
                try
                {
                    int x6 = 780000000;
                    int bigX = x6 * x6;
                }
                catch (OverflowException e6) { Console.WriteLine("6. " + e6.Message); }
            }

            // 7.
            try
            {
                File.OpenRead("Test.txt");
            }
            catch (FileNotFoundException e7) { Console.WriteLine("7. " + e7.Message); }

            // 8.
            try
            {
                string dir = @"c:\lBV balrfbaurb c,dbcalebfl";
                Directory.SetCurrentDirectory(dir);
            }
            catch (DirectoryNotFoundException e8) { Console.WriteLine("8. " + e8.Message); }

            // 9.
            try
            {
                DriveInfo d = new DriveInfo("M");
                Console.WriteLine(d.DriveFormat);
            }
            catch (DriveNotFoundException e9) { Console.WriteLine("9. " + e9.Message); }

            // 10.
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                Directory.SetCurrentDirectory(allDrives[0].Name);
                File.Create("test.txt");
            }
            catch (UnauthorizedAccessException e10) { Console.WriteLine("10. " + e10.Message); }

            // my exeption
            try 
            {
                if (5 > 4) throw new HomeWorkException("Поймалось моё исключение");

            }
            catch (HomeWorkException e) { Console.WriteLine("11. " + e.Message); }

        }

    }
    class HomeWorkException : Exception
    {
        public HomeWorkException(string message) :base(message) { }
    }
}
