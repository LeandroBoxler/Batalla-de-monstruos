namespace MiJuego.Interface 
{
   public class IWeapone
    {
        public string Name { get; set; }
        public int Attack { get; set; }

        public IWeapone(string name, int attack)
        {
            Name = name;
            Attack = attack;
        }
       
    } }