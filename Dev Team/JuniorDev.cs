using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Team
{
    abstract internal class JuniorDev : TeamMember
    {
        public int BugsCreatedPerHour { get; set; }

        protected int FourAttributes(string name, int hoursAtMaxEffeciency, int hoursAtReducedEffciency, int bugsCreatedPerHour) : base(name, hoursAtMaxEfficiency, hoursAtMaxEfficiency)
        {
            BugsCreatedPerHour = bugsCreatedPerHour;


        }

       
    }
}

