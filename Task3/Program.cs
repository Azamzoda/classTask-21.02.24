
Player pl1 = new Player();
System.Console.Write($"Enter player's name: ");
pl1.Name = Console.ReadLine();
System.Console.Write($"Enter player's number: ");
pl1.Number = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Enter player's position: ");
pl1.Position = Console.ReadLine();
System.Console.Write($"Enter player's team: ");
pl1.Team = Console.ReadLine();

System.Console.WriteLine();
pl1.ScoreGoal();
pl1.AssistGoal(Console.ReadLine());

Console.WriteLine(pl1.GetInfo());



class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;

    public void ScoreGoal()
    {
        Console.WriteLine($"Player {Name} scores a goal.");
    }

    public void AssistGoal(string playerName)
    {
        Console.WriteLine($"Player {Name} assist a goal for {playerName}");
    }

    public string GetInfo()
    {
        return $"PlayerName: {Name} \nNumber: {Number} \nPosition: {Position} \nTeam: {Team}";
    }
}
