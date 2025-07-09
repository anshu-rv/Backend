using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    interface IAnimals
    {
        public void Animalsvoice(); 
    }
}
class Pig : IAnimals
{
    public void Animalsvoice()
    {
        Console.WriteLine("pig is grunting");
    }
}
