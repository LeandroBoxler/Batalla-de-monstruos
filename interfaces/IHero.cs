namespace MiJuego.Interface 
{
    public interface IHero
    {
        string Name { get; set; }
        int Health { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Experience { get; set; }
        int Mana { get; set; }

        string Weapone { get; set; }

    List<Item> Inventary { get; set; }

        void ShowStats();
    }
}