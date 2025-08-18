using MiJuego.Interface;

public class Monster : IMonster
{

    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Health { get; set; }

    public int Level { get; set; }
    public List<string> EffectsStatus { get; } = new List<string>();


    public Monster(string name, int health, int attack, int defense)
    {
        Name = name;

        Health = health;

        Attack = attack;

        Defense = defense;

        Level = 1;



    }
    public void ShowStats()
    {
     
        Console.WriteLine($"{Name} - Vida: {Health} - Efectos: {string.Join(", ", EffectsStatus)}");



    }
}
