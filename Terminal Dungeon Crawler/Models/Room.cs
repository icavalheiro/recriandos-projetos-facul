using ProjetosFacul.TerminalDungeonCrawler.Items;

namespace ProjetosFacul.TerminalDungeonCrawler.Models;

public class Room
{
    public string Name { get; set; } = "Secret";
    public Room? East { get; set; }
    public Room? South { get; set; }
    public Room? North { get; set; }
    public Room? West { get; set; }

    public string Description { get; set; } = "No description available";
    public uint Difficulty { get; set; } = 1;
    public List<Monster> Monsters { get; set; } = new();
    public bool HasWater { get; set; }
    public bool IsOpenSpace { get; set; }
    public bool IsDark { get; set; }

    public List<IItem> Loot { get; set; } = new();
}