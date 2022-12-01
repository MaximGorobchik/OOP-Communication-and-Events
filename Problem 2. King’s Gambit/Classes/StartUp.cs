using Problem_2._King_s_Gambit.Classes;
using System;

public class StartUp
{
    private King king;
    private Royal_Guard guards;
    private Footman footmans;
    List<Units> units = new List<Units>();

    public void Start()
    {
        string kingName = Console.ReadLine();
        this.king = new King(kingName);
        var royalguardsName = Console.ReadLine().Split(" ");
        foreach (string name in royalguardsName)
        {
            this.guards = new Royal_Guard(name);
            this.king.KingRespond += this.guards.KingisAttacked;
            units.Add(this.guards);
        }
        var footmansName = Console.ReadLine().Split(" ");
        foreach (string name in footmansName)
        {
            this.footmans = new Footman(name);
            this.king.KingRespond += this.footmans.KingisAttacked;
            units.Add(this.footmans);
        }
        var end = Console.ReadLine();
        while (!end.Equals("End"))
        {
            var end_info = end.Split();
            if (end_info[0].Equals("Attack"))
            {
                this.king.KingIsAttacked();
            }
            end = Console.ReadLine();
            if (end_info[0].Equals("Kill"))
            {
                Units unit = this.units.FirstOrDefault(x => x.Name.Equals(end_info[1]));
                this.king.KingRespond -= unit.KingisAttacked; 
                units.Remove(unit);
            }
        }
    }
}