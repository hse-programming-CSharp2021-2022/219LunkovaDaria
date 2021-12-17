using System;
using System.Collections.Generic;
using System.Text;

namespace Task_01
{
    // Снегурочка.
    abstract class Person
    {
        public string Name { get; set; }
        public string Pocket { get; set; }
        public Random rnd = new Random();
        public abstract void Recieve(string pocket);        
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Name = {Name} Pocket = {Pocket}";
        }

    }
    class SnowMaiden : Person
    {
        public SnowMaiden(string name) : base(name) { }
        public override void Recieve(string present)
        {
            if (Pocket.Equals(string.Empty))
                Pocket = present;
            else
                throw new ArgumentException(">1 gifts");
        }
        public string CreateString()
        {
            int n = rnd.Next(4, 11);
            StringBuilder sb = new StringBuilder(n);
            for (int i = 0; i < n; i++)
            {
                sb.Append((char)rnd.Next('a', 'z' + 1));
            }
            return sb.ToString();
        }
        public string[] CreatePresents(int amount)
        {
            
            string[] gifts = new string[amount];
            for (int i = 0; i < amount; i++)
            {
                gifts[i] = CreateString();
            }
            return gifts;
        }

    }
    class Santa : Person
    {
        List<string> sack;
        public void Request(SnowMaiden snowMaiden, int amount)
        {
            sack.AddRange(snowMaiden.CreatePresents(amount));
        }
        public Santa(string name) : base(name) { }
        public override void Recieve(string pocket)
        {
            if (pocket.Equals(string.Empty))
                Pocket = pocket;
            else
                throw new ArgumentException(">1 gifts");
        }
        public void Give(Person person)
        {
            int n = rnd.Next(0, sack.Count);
            if (sack.Count > 0)
            {
                person.Recieve(sack[n]);
                sack.RemoveAt(n);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
    class Child : Person
    {
        public string AdditionalPocket { get; set; }
        public Child(string name) : base(name)
        {
            AdditionalPocket = string.Empty;
        }
        public override void Recieve(string pocket)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Santa santa = new Santa("Santa");
            SnowMaiden snowMaiden = new SnowMaiden("SnowMaiden");
            int n = 10;
            List<Person> people = new List<Person>(n + 2);
            people.Add(santa);
            people.Add(snowMaiden);
            do
            {

            }
        }
    }
}
