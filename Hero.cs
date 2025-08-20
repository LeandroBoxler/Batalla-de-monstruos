using MiJuego.Interface;


public class Hero : IHero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public int Dexterity { get; set; }
    public int Experience { get; set; }
    public int Mana { get; set; }
     public string Weapone { get; set; }

    public List<Item> Inventary { get; set; } = new List<Item>();

    public Hero(string name)
    {
        Name = name;
        Health = 120;
        Attack = 15;
        Defense = 10;
        Experience = 0;
        Dexterity = 15;
        Mana = 10;
        Weapone = "Cuchillo de cortar manteca";
    }
    public void ShowStats()
    {
        Console.WriteLine($"Jugador: {Name}");

        Console.WriteLine($"Ataque: {Attack}");

        Console.WriteLine($"Vida: {Health}");

        Console.WriteLine($"Defensa: {Defense}");
        
        Console.WriteLine($"Llevas equipado: {Weapone}");

        Console.WriteLine("--- Inventario ---");

    for (int i = 0; i < Inventary.Count; i++)
    {
        Console.WriteLine(Inventary[i]);
    }
    }
}