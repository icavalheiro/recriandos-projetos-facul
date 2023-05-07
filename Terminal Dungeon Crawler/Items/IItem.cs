namespace ProjetosFacul.TerminalDungeonCrawler.Items;

public interface IItem
{
    public string Name { get; }
    public string Description { get; }

    public bool IsEquipment { get; }
    public int Armor { get; set; }
    public int Attack { get; set; }
}