using MiJuego.Interface;

public class Dungeon
{
    private IHero hero;
    private int totalRooms;

    public Dungeon(IHero hero, int totalRooms)
    {
        this.hero = hero;
        this.totalRooms = totalRooms;
    }

    public void Start()
    {
        for (int i = 1; i <= totalRooms; i++)
        {
            Console.WriteLine($"Habitación {i} -Te espera un nuevo enemigo!");
            IMonster monster = MonsterFactory.CreateMonster();

            BattleSystem battle = new BattleSystem(hero, monster);
            bool heroWon = battle.StartBattle();
            if (hero.Health <= 0)
            {
                Console.WriteLine("💀 Has sido derrotado...");
                return;
            }

            Console.WriteLine($"🏆 Derrotaste al {monster.Name} y avanzas a la siguiente sala.");
        }

        Console.WriteLine("Has superado la mazmorra!");
    }
}
