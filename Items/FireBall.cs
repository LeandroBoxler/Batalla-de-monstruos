using MiJuego.Interface;


public class FireBall : Item
{
    public FireBall() : base("Bola de fuego") { }
    public override void Use(IHero hero, IMonster? monster)
    {
        if (monster != null)
        {
            if (!monster.EffectsStatus.Contains("Quemadura"))
            {
                monster.Health -= 40;
                monster.EffectsStatus.Add("Quemadura");
                Console.WriteLine($"{monster.Name} está siendo quemado.");
            }
        }
        else
        {
            Console.WriteLine("No hay un monstruo al que atacar con la Bola de fuego.");
        }
    }
}