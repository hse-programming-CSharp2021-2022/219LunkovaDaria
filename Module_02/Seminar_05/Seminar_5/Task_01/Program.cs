using System;

namespace Task_01
{
    abstract class Animal
    {
        protected abstract string Name { get; set; }
        protected abstract uint Age { get; set; }

        protected Animal(string name, uint age)
        {
            Age = age;
            Name = name;
        }

        public abstract string AnimalSound();
        public abstract string AnimalInfo();
    }

    class Dog : Animal
    {
        protected string Breed { get; }
        protected bool IsTrained { get; }
        protected override string Name { get; set; }
        protected override uint Age { get; set; }

        public Dog(string name, uint age, string breed, bool isTrained) : base(name, age) 
        {
            Breed = breed;
            IsTrained = isTrained;
        }

        public override string AnimalSound()
        {
            return "Woof!";
        }
        public override string AnimalInfo()
        {
            return $"doggo, it's name: {Name}, age: {Age}, breed: {Breed}, is it trained? - {IsTrained}.";
        }
    }

    class Cow : Animal
    {
        public override string AnimalSound() => "Mooooooooo!";
        protected override string Name { get; set; }
        protected override uint Age { get; set; }
        protected uint Milk { get; set; }
        public Cow(string name, uint age, uint milk) : base(name, age) { Milk = milk; }
        public override string AnimalInfo()
        {
            return $"cow, it's name: {Name}, age: {Age}, amount of milk: {Milk}.";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var doggo = new Dog("GoodBoi", 5, "shepherd", true);
            var cow = new Cow("Milka", 2, 4);

            Console.WriteLine(doggo.AnimalSound() + " - it was a " + doggo.AnimalInfo());
            Console.WriteLine(cow.AnimalSound() + " - it was a " + cow.AnimalInfo());
        }
    }
}
