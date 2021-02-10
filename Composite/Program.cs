using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var ms = new Organization("Microsoft");
            ms.Add(new Person("satyan", 10000));

            var substrateAi = new Organization("SubstrateAI");
            ms.Add(substrateAi);
            substrateAi.Add(new Person("shmurth", 100));

            Console.WriteLine($"Networth of MS is {ms.GetNetWorth()}");
            Console.WriteLine($"Networth of SubstrateAI is {substrateAi.GetNetWorth()}");
        }
    }
}
