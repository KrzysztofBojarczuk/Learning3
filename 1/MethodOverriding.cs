using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Fish myFish = new Fish();

            myDog.Breathe();
            myFish.Breathe();
        
        }
        
        class Animal
        {
            public string Name { get; set; }

            public virtual void Breathe()
            {
                Console.WriteLine("I'm breathing");
            }
        }
        
        class Dog : Animal
        {

        }
        class Fish : Animal
        {
            public override void Breathe()
            {
                Console.WriteLine("I'm breathing under water.");
            }
        }
    }
}
