namespace MiJuego.Interface 
{
   public class IWeapone
    {
        public string Name { get; set; }

        public IWeapone(string name)
        {
            Name = name;

        }
        public virtual void Use(IHero hero)
        {
            Console.WriteLine($"{Name} no tiene efecto.");



        }
    } }