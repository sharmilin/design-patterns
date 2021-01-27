using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IHouse myHome = new FullyFurnishedDecorator(new TwoBhk());
            Console.WriteLine($"Description : {myHome.GetDescription()}");
            Console.WriteLine($"Price : {myHome.GetPrice()}");
        }
    }
}
