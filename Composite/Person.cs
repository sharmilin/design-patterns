using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Person : Hierarchy
    {
        private int Worth { get; }
        
        public Person(string name, int worth) : base(name)
        {
            this.Worth = worth;
        }

        public override int GetNetWorth()
        {
            return this.Worth;
        }
    }
}
