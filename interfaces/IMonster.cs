
namespace MiJuego.Interface {
public interface IMonster
{
    string Name { get; set; }
    int Health { get; set; }
    int Attack { get; set; }
    int Defense { get; set; }

    List<string> EffectsStatus { get; }

    int Level { get; set; }

    void ShowStats();
}
}