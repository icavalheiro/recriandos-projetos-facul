// See https://aka.ms/new-console-template for more information
using ProjetosFacul.TerminalDungeonCrawler.Generators;

for (var i = 0; i < 15; i++)
{
    Console.WriteLine(MonsterGenerator.GenerateOne(1));
}