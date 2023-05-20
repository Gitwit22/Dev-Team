using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Team
{
    internal class DevTeam
    {
        public double ShiftLength { get; set; }


       private List<TeamMember> teamMembers = new List<TeamMember>();

        private double numberOfBugsCreated;
        private double numberOfBugsFixed;


        public DevTeam(double shiftLength) 
        {
            ShiftLength = shiftLength;
        }

        public void AddTeamMember(TeamMember teamMember)
        {
            teamMembers.Add(teamMember);
        }


        public double GetCurrentBugCount()
        {
            return numberOfBugsCreated - numberOfBugsFixed;
        }

        public void WorkShift()
        {
            for(int i = 0; i < ShiftLength; i++) 
            { 
                
                foreach(TeamMember teamMember in teamMembers)
                {
                    double adjustedValue = teamMember.GetBugAdjustmentValue();

                    if (adjustedValue > 0)
                    {
                        numberOfBugsCreated += adjustedValue;
                    } else if (adjustedValue < 0)
                    {
                        numberOfBugsFixed += Math.Abs(adjustedValue);
                    }
                }
                Console.WriteLine($"Hour {i + 1} number of bugs created {numberOfBugsCreated} bugs fixed {numberOfBugsFixed}" ); 







            }
        }









    }
    
}
