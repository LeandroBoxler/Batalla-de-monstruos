using MiJuego.Interface;

public abstract class Item
{
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }

    public virtual void Use(IHero hero, IMonster? monster = null)
    {
        Console.WriteLine($"{Name} no tiene efecto.");
    }
}
