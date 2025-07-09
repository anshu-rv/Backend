using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal /*sealed*/ class Mycar
    {
        public string name = "bmw";
        public void hook()
        {
            Console.WriteLine("bmw car");
        }
    }
    class Mynewcar:Mycar
    {
        public string carname="audi";
    }
}
