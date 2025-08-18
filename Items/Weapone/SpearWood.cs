
using MiJuego.Interface;

public class SpearWood : IWeapone
{
    public SpearWood() : base("Lanza de madera") { }
    public override void Use(IHero hero)
    {
        hero.Attack = 40;

    }
}