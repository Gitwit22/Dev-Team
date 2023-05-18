

//using TeamMembers_and_JuniorDev;


static int GetBugAdjustmentValue(int CurrentHoursWorked, int HoursAtMaxEfficiency, int BugsCreatedPerHour, int TotalHoursWorked)
{
    if (CurrentHoursWorked <= HoursAtMaxEfficiency)
    {
        return BugsCreatedPerHour;

    } 
    else if (CurrentHoursWorked > HoursAtMaxEfficiency || CurrentHoursWorked <= TotalHoursWorked) 
    {
        return BugsCreatedPerHour * 2;
    } 

    if (CurrentHoursWorked > TotalHoursWorked) 
    
    {
        return 0;
    }


        }