using MiJuego.Interface;


public static class MonsterFactory
{
    private static Random rnd = new Random();

    public static IMonster CreateMonster()
    {
        int choice = rnd.Next(0, 3); 

        return choice switch
        {
            0 => new Monster("Goblin", 50, 15, 5),
            1 => new Monster("Orco", 70, 20, 10),
            2 => new Monster("Esqueleto", 40, 10, 3),
            3 => new Monster("Slime",30,40,30),
            _ => new Monster("Goblin", 50, 15, 5)
        };
    }
}
