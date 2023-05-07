namespace ProjetosFacul.TerminalDungeonCrawler;

public class Monster
{
    public int Attack { get; set; } = 10;
    public int Life { get; set; } = 100;
    public int Armor { get; set; } = 1;
    public string Profession { get; set; } = "Undefined";
    public string Race { get; set; } = "Undefined";
    public bool PlayerAware { get; set; } = false;
}