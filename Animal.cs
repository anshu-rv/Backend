using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public virtual void Animalsound()
        {
            Console.WriteLine("Animal is making sound");
        }
    }
    class Dogs : Animal
    {
        public override void Animalsound()
        {
            Console.WriteLine("Dog is barking");
        }

    }
    class Cats : Animal
    {
        public override void Animalsound()
        {
            Console.WriteLine("Cat is meowing");
        }
    }
}
