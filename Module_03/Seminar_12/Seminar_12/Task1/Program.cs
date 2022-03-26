using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task1
{
    //Класс Student (студент) включает фамилию и номер курса.
    //Класс Group(группа) включает ее обозначение и список студентов.
    //Определить две группы и сохранить их в файле, применяя двоичную сериализацию|xml|json.
    //Прочитать данные из файла и восстановить объекты класса Группа.
   
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public uint Course { get; set; }

        public Student() { }
        public Student (string name, uint course)
        {
            (Name, Course) = (name, course);
        }
        public override string ToString()
        {
            return $"{this.Name}, {this.Course}";
        }
    }
    [Serializable]
    public class Group
    {
        public string GroupId { get; set; }
        public List<Student> Students { get; set; }

        public Group() { }
        public Group (string groupId, List<Student> students)
        {
            (GroupId, Students) = (groupId, students);
        }

        public override string ToString()
        {
            return $"{this.GroupId}:\n{string.Join("; ", Students)}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Binary Formatter: ");
            Group group1 = new Group("219", new List<Student> {
                new Student("Vanya", 1), new Student("Katya", 1) , new Student("Masha", 1)});
            Group group2 = new Group("2191", new List<Student> { 
                new Student("Pasha", 2), new Student("Sveta", 3) });
            Group[] groups = { group1, group2 };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream("out1.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(file, groups);
            }
            using (FileStream file = new FileStream("out1.txt", FileMode.OpenOrCreate))
            {
                Group[] binGroup = (Group[])formatter.Deserialize(file);
                Array.ForEach(binGroup, el => Console.WriteLine(el));
            }

            Console.WriteLine("\n Xml: ");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Group[]));
            using (FileStream file = new FileStream("out2.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, groups);
            }
            using (FileStream file = new FileStream("out2.txt", FileMode.OpenOrCreate))
            {
                Group[] xmlGroup = (Group[])xmlSerializer.Deserialize(file);
                Array.ForEach(xmlGroup, el => Console.WriteLine(el));
            }

            Console.WriteLine("\n Json: ");
            string json = JsonSerializer.Serialize<Group[]>(groups);
            Group[] jsonGroup = JsonSerializer.Deserialize<Group[]>(json);
            Array.ForEach(jsonGroup, el => Console.WriteLine(el));
        }
    }
}
