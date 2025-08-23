namespace MiJuego.Interface 
{
    public interface IHero
    {
        string Name { get; set; }
        int Health { get; set; }
        int BaseAttack { get; set; }
        int Defense { get; set; }

        IWeapone? Weapone { get; set; }

        int Attack {  get; }
        List<Item> Inventary { get; set; }

        void ShowStats();
    }
}