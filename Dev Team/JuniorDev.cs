using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Team
{
     internal class JuniorDev : TeamMember
    {
        public double BugsCreatedPerHour { get; set; }

        public JuniorDev(string name, double hoursAtMaxEffeciency, double hoursAtReducedEffciency, double bugsCreatedPerHour) : base(name, hoursAtMaxEffeciency, hoursAtReducedEffciency)
        {
            BugsCreatedPerHour = bugsCreatedPerHour;


        }
        
        public override double GetBugAdjustmentValue()
        {
            if (CurrentHoursWorked <= HoursAtMaxEfficiency)
            {
                return BugsCreatedPerHour;

            }
            else if (CurrentHoursWorked > HoursAtMaxEfficiency || CurrentHoursWorked <= TotalHoursWorked)
            {
                return BugsCreatedPerHour * 2;
            }

            else

            {
                return 0;
            }


        }
    }
}

