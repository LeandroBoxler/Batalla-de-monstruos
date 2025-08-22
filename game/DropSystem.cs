using MiJuego.Interface;

public class DropSystem
{

    public DropSystem(IMonster monster, IHero hero)
    {
            Console.WriteLine($"-------------- Seleccione un item ------------");

            for (int i = 0; i < monster.Loot.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {monster.Loot[i].Name} ");
            }
            string? inputDrop = Console.ReadLine();

            if (int.TryParse(inputDrop, out int index))
            {
                int dropSelect = index - 1;
            if (dropSelect >= 0 && dropSelect < monster.Loot.Count)
            {
                hero.Inventary.Add(monster.Loot[dropSelect]);
                Console.WriteLine($"{monster.Loot[dropSelect].Name} agregado al inventario.");

                }
            else Console.WriteLine("Valor invalido.");


            }
            else Console.WriteLine("Valor invalido.");
            
        }

 
}
