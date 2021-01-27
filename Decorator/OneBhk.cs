using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class OneBhk : IHouse
    {
        public string GetDescription()
        {
            return "This house has 1 BHK";
        }

        public int GetPrice()
        {
            return 100;
        }
    }
}
