using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class FullyFurnishedDecorator : IHouse
    {
        private IHouse house;

        public FullyFurnishedDecorator(IHouse house)
        {
            this.house = house;
        }

        public string GetDescription()
        {
            return this.house.GetDescription() + " and is fully furnished";
        }

        public int GetPrice()
        {
            return this.house.GetPrice() + 200;
        }
    }
}
