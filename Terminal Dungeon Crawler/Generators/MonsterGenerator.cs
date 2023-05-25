using System.IO;
using ProjetosFacul.TerminalDungeonCrawler.Models;

namespace ProjetosFacul.TerminalDungeonCrawler.Generators;

public static class MonsterGenerator
{
    private const string ProfessionsCsvPath = "./Data/monster_professions.csv";
    private const string RacesCsvPath = "./Data/monster_races.csv";

    private static string GetRace(Random random)
    {
        using (var file = File.OpenText(RacesCsvPath))
        {
            var content = file.ReadToEnd();
            var lines = content.ReplaceLineEndings("\n").Split("\n");
            return lines[random.Next(0, lines.Length)];
        }
    }

    private static string GetProfession(Random random)
    {
        using (var file = File.OpenText(ProfessionsCsvPath))
        {
            var content = file.ReadToEnd();
            var lines = content.ReplaceLineEndings("\n").Split("\n");
            return lines[random.Next(0, lines.Length)];
        }
    }

    private static int GetAttack(int difficultyLevel, Random random)
    {
        const int baseAttack = 10;
        const int attackPerLevel = 3;

        var attack = baseAttack + (int)((attackPerLevel * difficultyLevel) * ((random.NextDouble() * 0.6f) + 1.1f));

        return attack;
    }

    private static int GetArmor(int difficultyLevel, Random random)
    {
        const int baseArmor = 0;
        const int armorPerLevel = 1;

        var armor = baseArmor + (int)((armorPerLevel * difficultyLevel) * ((random.NextDouble() * 2f)));

        return armor;
    }

    private static int GetLife(int difficultyLevel, Random random)
    {
        const int baseLife = 150;
        const int lifePerLevel = 20;

        var life = baseLife + (int)((lifePerLevel * difficultyLevel) * ((random.NextDouble() * 3f) + 1f));

        return life;
    }

    public static Monster GenerateOne(int difficultyLevel, Random? random = null)
    {
        if (random == null)
            random = new();

        return new()
        {
            Profession = GetProfession(random),
            Race = GetRace(random),
            Attack = GetAttack(difficultyLevel, random),
            Life = GetLife(difficultyLevel, random),
            Armor = GetArmor(difficultyLevel, random)
        };
    }
}