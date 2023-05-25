// See https://aka.ms/new-console-template for more information
using ProjetosFacul.TerminalDungeonCrawler.Generators;

Random random = new(321876412);

for (var i = 0; i < 15; i++)
{
    Console.WriteLine(MonsterGenerator.GenerateOne(5, random));
}