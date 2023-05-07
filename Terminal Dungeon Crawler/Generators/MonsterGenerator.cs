using System.IO;
namespace ProjetosFacul.TerminalDungeonCrawler.Generators;

public static class MonsterGenerator
{
    private const string ProfessionsCsvPath = "./Data/monster_professions.csv";
    private const string RacesCsvPath = "./Data/monster_races.csv";
    private static Random Random = new();


    private static string GetRace()
    {
        using (var file = File.OpenText(RacesCsvPath))
        {
            var content = file.ReadToEnd();
            var lines = content.ReplaceLineEndings("\n").Split("\n");
            return lines[Random.Next(0, lines.Length)];
        }
    }

    private static string GetProfession()
    {
        using (var file = File.OpenText(ProfessionsCsvPath))
        {
            var content = file.ReadToEnd();
            var lines = content.ReplaceLineEndings("\n").Split("\n");
            return lines[Random.Next(0, lines.Length)];
        }
    }

    private static int GetAttack(int difficultyLevel)
    {
        const int baseAttack = 10;
        const int attackPerLevel = 3;

        var attack = baseAttack + (int)((attackPerLevel * difficultyLevel) * ((Random.NextDouble() * 0.6f) + 1.1f));

        return attack;
    }

    private static int GetArmor(int difficultyLevel)
    {
        const int baseArmor = 0;
        const int armorPerLevel = 1;

        var armor = baseArmor + (int)((armorPerLevel * difficultyLevel) * ((Random.NextDouble() * 0.6f) + 1.1f));

        if (armor > 15)
            return 15;

        return armor;
    }

    private static int GetLife(int difficultyLevel)
    {
        const int baseLife = 150;
        const int lifePerLevel = 20;

        var life = baseLife + (int)((lifePerLevel * difficultyLevel) * ((Random.NextDouble() * 3f) + 1f));

        return life;
    }

    public static Monster GenerateOne(int difficultyLevel)
    {
        return new()
        {
            Profession = GetProfession(),
            Race = GetRace(),
            Attack = GetAttack(difficultyLevel),
            Life = GetLife(difficultyLevel),
            Armor = GetArmor(difficultyLevel)
        };
    }
}