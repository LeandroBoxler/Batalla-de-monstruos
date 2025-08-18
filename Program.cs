using MiJuego.Interface;

class Program
{
    static void Main()
{


        var hero1 = new HeroFactory();
        var hero = hero1.GenerateHero();
        hero.ShowStats();

    

        IMonster monster = MonsterFactory.CreateMonster();
        monster.ShowStats();

        Dungeon dungeon = new Dungeon(hero, 5);
        dungeon.Start();
         hero.ShowStats();
        Console.WriteLine("GAME OVER...");
    }
}
