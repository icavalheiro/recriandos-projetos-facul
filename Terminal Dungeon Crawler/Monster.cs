namespace ProjetosFacul.TerminalDungeonCrawler;

public class Monster
{
    public enum RaceType
    {
        Undefined,
        Elf,
        Orc,
        Goblin,
        Draconian,
        Human,
        Corlash,
        Zombie,
        Murlok,
        Petrorian,
        Rhynorian,
        Blumper,
        Giant,
        Mermaid
    }

    public string Name { get; set; } = "Secret";
    public int Attack { get; set; } = 10;
    public int Life { get; set; } = 100;
    public int Armor { get; set; } = 1;
    public string Description { get; set; } = "No description available";
    public RaceType Race { get; set; }
}