﻿public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();
        for (int i = 0; i < n; i++)
        {
            var teamsCreation = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();
            var creator = teamsCreation[0];
            var name = teamsCreation[1];
            bool teamExists = teams.Any(t => t.Name == name);
            bool creatorExists = teams.Any(t => t.Creator == creator);

            if (teamExists)
            {
                Console.WriteLine($"Team {name} was already created!");
            }
            else if (creatorExists)
            {
                Console.WriteLine($"{creator} cannot create another team!");
            }
            else
            {
                Team team = new Team(name, creator);
                teams.Add(team);
                Console.WriteLine($"Team {name} has been created by {creator}!");
            }
        }
        var availableTeams = new List<string>();
        foreach (var item in teams)
        {
            availableTeams.Add(item.Name);
        }
        while (true)
        {
            var playerWantToJoin = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToList();
            if (playerWantToJoin[0] == "end of assignment")
            {
                break;
            }
            var wannaBe = playerWantToJoin[0];
            var teamToJoin = playerWantToJoin[1];


            if (!availableTeams.Contains(teamToJoin))
            {
                Console.WriteLine($"Team {teamToJoin} does not exist!");
                continue;
            }
            bool exist = false;
            foreach (var item in teams)
            {
                if (item.Members.Contains(wannaBe))
                {
                    Console.WriteLine($"Member {wannaBe} cannot join team {teamToJoin}!");
                    exist = true;
                    break;
                }
            }

            if (!exist)
            {
                int index = 0;
                foreach (var item in teams)
                {
                    if (item.Name == teamToJoin)
                    {
                        index = teams.IndexOf(item);
                        break;
                    }
                }
                teams[index].Members.Add(wannaBe);
            }
        }
        teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

        var teamsToDisband = new List<string>();
        foreach (var item in teams)
        {
            if (item.Members.Count > 1)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine($"- {item.Creator}");
                item.Members.Remove(item.Creator);
                item.Members = item.Members.OrderBy(x => x).ToList();
                item.Members.ForEach(x => Console.WriteLine($"-- {x}"));
            }
            else
            {
                teamsToDisband.Add(item.Name);
            }
        }
        Console.WriteLine("Teams to disband:");
        //Delete the teams with only Creator 
        Console.WriteLine(string.Join(Environment.NewLine, teamsToDisband));

    }

}
public class Team
{
    public string Name { get; set; }
    public List<string> Members { get; set; } = new List<string>();
    public string Creator { get; set; }
    public Team(string name, string creator)
    {
        this.Name = name;
        this.Creator = creator;
        Members.Add(creator);
    }
}