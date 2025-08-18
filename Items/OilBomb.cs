using MiJuego.Interface;


public class OilBomb : Item
{
    public OilBomb() : base("Bomba de Aceite") { }
    public override void Use(IHero hero, IMonster? monster)
    {
        if (monster != null)
        {
            if (!monster.EffectsStatus.Contains("Aceitado"))
            {
                monster.EffectsStatus.Add("Aceitado");
                Console.WriteLine($"{monster.Name} está cubierto de aceite.");
            }
        }
        else
        {
            Console.WriteLine("No hay un monstruo al que atacar con la Bomba de Aceite.");
        }
    }
}