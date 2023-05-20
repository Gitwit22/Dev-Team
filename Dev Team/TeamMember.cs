
//team members class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Team
{
   abstract internal class TeamMember
    {
        public string Name { get; set; }
        public double HoursAtMaxEfficiency { get; set; }
        public double HoursAtReducedEfficiency { get; set; }
        public double TotalHoursWorked { get; private set; }
        public double CurrentHoursWorked { get; set; } = 0;


    

    
    protected TeamMember(string name, double hoursAtMaxEffeciency, double hoursAtReducedEffciency)
    {
        Name = name;
        HoursAtMaxEfficiency = hoursAtMaxEffeciency;
        HoursAtReducedEfficiency = hoursAtReducedEffciency;

            TotalHoursWorked = HoursAtMaxEfficiency + HoursAtReducedEfficiency;
        
              
    }

        public abstract double GetBugAdjustmentValue();
        
        

    }
}
