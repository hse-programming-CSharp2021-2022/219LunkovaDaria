using System;
using System.IO;
using System.Text;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";

            // Создаем файл с данными
            //File.Create(path);
            if (File.Exists(path))
            {
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                int n = 6;
                Random rnd = new Random();
                StringBuilder createText = new StringBuilder();
                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j < 5; j++)
                        createText.Append(rnd.Next(10, 100) + " ");
                    createText.Append(Environment.NewLine);
                }
                
                File.WriteAllText(path, createText.ToString(), Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                    if ((i + 1) % 5 == 0)
                        Console.WriteLine();
                }
                Console.WriteLine();
                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                int[] chet = new int[arr.Length];
                int[] nechet = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                        chet[i] = i;
                    else 
                        nechet[i] = i;
                }
                // TODO3: Заменяем все нечётные числа исходного массива нулями
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Array.Exists(nechet, num => num == i))
                    {
                        arr[i] = 0; 
                    }
                    Console.Write(arr[i] + " ");
                    if ((i + 1) % 5 == 0)
                        Console.WriteLine();
                }
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}
