using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract class Hierarchy
    {
        public Hierarchy(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public abstract int GetNetWorth();
    }
}
