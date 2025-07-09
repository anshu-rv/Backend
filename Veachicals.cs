using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Veachicals
    {
        public abstract void Display();
        public void sleep()
        {
            Console.WriteLine("sleep zz...");

        } 
    }
    class Cycle:Veachicals
    {
        public override void Display()
        {
            Console.WriteLine("Cycle is running");
        }
    }
}
