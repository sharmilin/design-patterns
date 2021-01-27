using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class SemiFurnishedDecorator : IHouse
    {
        private IHouse house;

        public SemiFurnishedDecorator(IHouse house)
        {
            this.house = house;
        }

        public string GetDescription()
        {
            return this.house.GetDescription() + " and is semi furnished";
        }

        public int GetPrice()
        {
            return this.house.GetPrice() + 100;
        }
    }
}
