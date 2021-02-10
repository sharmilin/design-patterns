using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Organization : Hierarchy
    {
        private List<Hierarchy> OrgChart = new List<Hierarchy>();

        public Organization(string name) : base(name)
        {
        }

        public override int GetNetWorth()
        {
            return this.OrgChart.Sum(x => x.GetNetWorth());
        }

        public void Add(Hierarchy h)
        {
            this.OrgChart.Add(h);
        }

        public void Remove(Hierarchy h)
        {
            this.OrgChart.Remove(h);
        }
    }
}
