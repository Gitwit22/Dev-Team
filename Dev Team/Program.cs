

//program;


using Dev_Team;

DevTeam myTeam = new DevTeam(8);
myTeam.AddTeamMember(new JuniorDev("Drew", 2, 4, 3));
myTeam.AddTeamMember(new JuniorDev("Alicia", 3, 3, 2));
myTeam.AddTeamMember(new JuniorDev("Roy", 4, 4, 1));
myTeam.AddTeamMember(new JuniorDev("Doreen", 5, 3, 1));
myTeam.AddTeamMember(new SeniorDev("Scott", 5, 3, 4));
myTeam.AddTeamMember(new SeniorDev("Greg", 6, 2, 4));
myTeam.WorkShift();
Console.WriteLine($"There are currently {myTeam.GetCurrentBugCount()} bugs yet to be fixed.");
Console.ReadKey();

