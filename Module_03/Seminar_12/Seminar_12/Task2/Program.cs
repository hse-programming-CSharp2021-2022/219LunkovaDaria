using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Task2
{
    //В программе описать классы:
    //•Human(имя);
    //•Professor(наследник Human);
    //•Department(название, композиционно включает список сотрудников – объекты типа Human);
    //•University(название, агрегационно включает список департаментов).
    //•Задать массив университетов.Сериализовать и десериализовать бинарной/xml/json.
    [Serializable]
    public class Human
    {
        public string Name { get; set; }
        public Human() { Name = ""; }
        public Human(string name) => Name = name;
        public override string ToString()
        {
            return $"Human {Name}";
        }
    }

    [Serializable]
    public class Professor : Human
    {
        public Professor() : base() { }
        public Professor(string name) : base(name) { }
        public override string ToString()
        {
            return $"Professor {Name}";
        }
    }

    [Serializable]
    public class Department
    {
        public string Name { get; set; }
        [JsonInclude]
        public List<Human> Workers;

        public Department() 
        {
            Name = "";
            Workers = new();
        }
        public Department(string name, List<Human> workers)
        {
            Name = name;
            Workers = workers;
        }
        public override string ToString()
        {
            return $"Department of {Name}.\nWorkers:\n{string.Join(",\n", Workers)}";
        }
    }

    [Serializable]
    public class University
    {
        public string Name { get; set; }
        [JsonInclude]
        public List<Department> Departments;

        public University()
        {
            Name = "";
            Departments = new();
        }
        public University(string name, List<Department> departments)
        {
            Name = name;
            Departments = departments;
        }
        public override string ToString()
        {
            return $"University {Name}.\nDepartments:\n{string.Join(" \n", Departments)}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            University Harvard = new University("Harvard", new List<Department>());
            Harvard.Departments.Add(new Department("History",
                new List<Human> { new Professor("Cristoforo Colombo"), new Human("Bob"), new Human("Alice") }));
            Harvard.Departments.Add(new Department("Physics",
                new List<Human> { new Professor("Albert Einstein"), new Human("Mark"), new Human("Robert"), new Human("John") }));

            University HSE = new University("HSE", new List<Department>());
            HSE.Departments.Add(new Department("Computer Sciense",
                new List<Human> { new Professor("Gordenko"), new Human("Dasha") }));

            University[] Universities = { Harvard, HSE };

            Console.WriteLine("Binary Formatter: ");
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream("out1.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, Universities);
            }
            using (FileStream file = new FileStream("out1.txt", FileMode.OpenOrCreate))
            {
                University[] binGroup = (University[])formatter.Deserialize(file);
                Array.ForEach(binGroup, el => Console.WriteLine(el));
            }

            Console.WriteLine("\n Xml: ");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(University[]), new Type[] {
                typeof(Human), typeof(Professor)});
            using (FileStream file = new FileStream("out2.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, Universities);
            }
            using (FileStream file = new FileStream("out2.txt", FileMode.OpenOrCreate))
            {
                University[] xmlGroup = (University[])xmlSerializer.Deserialize(file);
                Array.ForEach(xmlGroup, el => Console.WriteLine(el));
            }

            Console.WriteLine("\n Json: ");
            using (StreamWriter stream1 = new StreamWriter("out3.txt",false))
            {
                stream1.Write(JsonSerializer.Serialize<University[]>(Universities));
            }
            using (StreamReader stream1 = new StreamReader("out3.txt"))
            {
                University[] jsonGroup = JsonSerializer.Deserialize<University[]>(stream1.ReadToEnd());
                Array.ForEach(jsonGroup, el => Console.WriteLine(el));
            }
        }
    }
}
