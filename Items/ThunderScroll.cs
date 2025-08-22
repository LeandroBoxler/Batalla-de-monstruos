using MiJuego.Interface;

public class ThunderScroll : Item
{
    public ThunderScroll() : base("Scroll de rayo") { }

    public override void Use(IHero hero, IMonster? monster = null)
    {
        if (monster != null)
        {


            int damage = monster.EffectsStatus.Contains("Mojado") ? 100 : 40;
            Console.WriteLine($"Hiciste {damage} de daño a {monster.Name}.");
        
}
        else
        {
            Console.WriteLine("No hay un monstruo al que atacar con scroll de rayo.");
        }
    }
}