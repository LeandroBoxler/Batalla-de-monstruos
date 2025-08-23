using MiJuego.Interface;

public class Hero : IHero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int BaseAttack { get; set; }
    public int Defense { get; set; }

    public IWeapone? Weapone { get; set; }
    public List<Item> Inventary { get; set; } = new List<Item>();

    public int Attack => BaseAttack + (Weapone?.Attack ?? 0);

    public Hero(string name)
    {
        Name = name;
        Health = 120;
        BaseAttack = 15;
        Defense = 10;
        Weapone = null;
    }

    public void ShowStats()
    {
        Console.WriteLine($"Jugador: {Name}");
        Console.WriteLine($"Ataque: {Attack}");
        Console.WriteLine($"Vida: {Health}");
        Console.WriteLine($"Defensa: {Defense}");
        Console.WriteLine($"Arma equipada: {(Weapone != null ? Weapone.Name : "Ninguna")}");
    }
}
