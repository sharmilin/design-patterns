using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class TwoBhk : IHouse
    {
        public string GetDescription()
        {
            return "This house has 2 BHK";
        }

        public int GetPrice()
        {
            return 200;
        }
    }
}
