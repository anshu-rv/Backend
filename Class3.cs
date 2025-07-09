

namespace ConsoleApp1
{
    interface IFirstInterface
    {
        public void MyMethod();
    }
    interface ISecondInterface
    {
        public void MyOtherMethod();
    }
    class DemoClass :IFirstInterface,ISecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("This is the first method from the first interface.");
        }
        public void MyOtherMethod()
        {
            Console.WriteLine("This is second interface");
        }
    }
    
}

