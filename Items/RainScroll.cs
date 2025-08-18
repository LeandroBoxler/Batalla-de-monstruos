using MiJuego.Interface;


public class RainScroll : Item
{
    public RainScroll() : base("Scroll de lluvia") { }
    public override void Use(IHero hero, IMonster? monster)
    {
        if (monster != null)
        {
            if (!monster.EffectsStatus.Contains("Mojado"))
            {
                monster.EffectsStatus.Add("Mojado");
                Console.WriteLine($"{monster.Name} está mojado.");
            }
        }
        else
        {
            Console.WriteLine("No hay un monstruo al que mojar con la lluvia.");
        }
    }
}