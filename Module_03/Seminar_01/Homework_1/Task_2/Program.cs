using System;

namespace Task_2
{
    //01_a #3
    class TemperatureConvertImp
    {
        public double CelsToF(double x)
        {
            return 9.0 / 5 * x + 32;
        }
        public double FToCels(double x)
        {
            return 5.0 / 9 * (x - 32);
        }
    }

    class StaticTempConverters
    {
        public static double CtoK(double x)
        {
            return x + 273.15;
        }
        public static double CtoRank(double x)
        {
            return (x + 273.15) * 9 / 5;
        }
        public static double CtoRe(double x)
        {
            return x * 4 / 5;
        }
        public static double KtoC(double x)
        {
            return x - 273.15;
        }
        public static double RankToC(double x)
        {
            return (x - 491.67) * 5 / 9;
        }
        public static double ReToC(double x)
        {
            return x * 5 / 4;
        }
    }

    delegate double DelegateConvertTemperature(double x);
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConvertImp temperature = new TemperatureConvertImp();
            DelegateConvertTemperature del1 = 
                new DelegateConvertTemperature(temperature.CelsToF);
            DelegateConvertTemperature del2 =
                new DelegateConvertTemperature(temperature.FToCels);
            double t;
            t = del1(50.5);
            Console.WriteLine($"{t:f3}");
            t = del2(50.5);
            Console.WriteLine($"{t:f3}");

            DelegateConvertTemperature[] mas = {del1, del2, StaticTempConverters.CtoK,
                StaticTempConverters.CtoRank, StaticTempConverters.CtoRe,
                StaticTempConverters.KtoC, StaticTempConverters.RankToC, StaticTempConverters.ReToC};
            
            foreach (var del in mas)
            {
                Console.WriteLine("50\t" + del.Method.Name + "\t\t" + $"{del(50):f3}");
            }
        }
    }
}
