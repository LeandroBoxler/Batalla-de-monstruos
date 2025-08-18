using MiJuego.Interface;

public class HealthPotion : Item
{
    public HealthPotion() : base("Poción de Vida") { }
    public override void Use(IHero hero, IMonster? monster)
    {

        hero.Health += 50;

        Console.WriteLine($"{hero.Name} usa una {this.Name} y restaura {50} de vida.");
        Console.WriteLine($"La salud de {hero.Name} ahora es: {hero.Health}.");

    }
}