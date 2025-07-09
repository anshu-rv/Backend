// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            Car c = new Car();
            Car Ford = new Car();
            Bike b = new Bike();
            Stud s = new Stud("anshu",21,91);
            Dog d = new Dog();
            d.Name = "xyx";
            Mynewcar mycar = new Mynewcar();
            mycar.hook();
        
            Console.WriteLine(mycar.carname+" "+mycar.name);
            Animal animal = new Animal();
            Animal cats = new Cats();
            Animal dogs = new Dogs();
            animal.Animalsound();
            cats.Animalsound();
            dogs.Animalsound();
            Cycle cycle = new Cycle();
            cycle.sleep();
            cycle.Display();
            Pig pig = new Pig();
            pig.Animalsvoice();
            DemoClass demo = new DemoClass();
            demo.MyMethod();
            demo.MyOtherMethod();

            Console.WriteLine(d.Name);

            Console.WriteLine(s.name + " " + s.id + " " + s.age);
            Console.WriteLine(c.color);
            Console.WriteLine(c.speed);
            Console.WriteLine(b.color);
            Console.WriteLine(b.name);
            Console.WriteLine(Ford.name = "Ford");
            Console.WriteLine(Ford.model = "Mustang");
            c.Display();
            
        }
        //{
        //    Console.WriteLine("Hello" + name );
        //    Console.WriteLine("You are" + age +"years old");
        //    Console.ReadLine();
        //}
        //static void Main(string[] args)
        //{
        //    Fun("Anshu",21);
        //    Fun("Bhaskar", 20);
        //    Fun("Deepthi", 20);
        //}
        }
       }














