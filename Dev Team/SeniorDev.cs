
//Senior dev claa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Team
{

   
    internal class SeniorDev : TeamMember
    {
        public double BugsFixedPerHour { get; set; }

        public SeniorDev(string name, double hoursAtMaxEfficiency, double bugsFixedPerHour, double hoursAtReducedEfficiency) : base(name, hoursAtMaxEfficiency, hoursAtReducedEfficiency)
        {

            BugsFixedPerHour = bugsFixedPerHour;


        }


        public override double GetBugAdjustmentValue()
        {
            if (CurrentHoursWorked <= HoursAtMaxEfficiency)
            {
                return 0 - BugsFixedPerHour;

            }
            else if (CurrentHoursWorked > HoursAtMaxEfficiency || CurrentHoursWorked <= TotalHoursWorked)
            {
                return 0 - Math.Ceiling(BugsFixedPerHour / 2);
            }

            else 

            {
                return 0;
            }


        }
    }
}
