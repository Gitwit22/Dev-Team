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
        public int HoursAtMaxEfficiency { get; set; }
        public int HoursAtReducedEfficiency { get; set; }
        public int TotalHoursWorked { get; set; }
        private int CurrentHoursWorked { get; } = 0;


    

    
    protected int ThreeAttributes(string name, int hoursAtMaxEffeciency, int hoursAtReducedEffciency)
    {
        Name = name;
        HoursAtMaxEfficiency = hoursAtMaxEffeciency;
        HoursAtReducedEfficiency = hoursAtReducedEffciency;

    int TotalWorkHours = HoursAtMaxEfficiency + HoursAtReducedEfficiency;
        return TotalWorkHours;
              
    }

        public abstract int GetBugAdjustmentValue();
        


    }
}
