using MiJuego.Interface;


public class FireBall : Item
{
    public FireBall() : base("Bola de fuego") { }
    public override void Use(IHero hero, IMonster? monster)
    {
        
        if (monster != null)
        {
            int damage = monster.EffectsStatus.Contains("Aceitado") ? 100 :40;
        Console.WriteLine($"Hiciste {damage} de daño a {monster.Name}.");

            if (!monster.EffectsStatus.Contains("Quemadura"))
            {
                monster.Health -= damage;
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