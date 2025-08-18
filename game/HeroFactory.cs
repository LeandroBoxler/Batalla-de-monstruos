using MiJuego.Interface;


public class HeroFactory
{
    public IHero GenerateHero()
    {
        Console.WriteLine("Ingresa tu nombre");
        
        string? nameInput = Console.ReadLine();
        string heroName = nameInput ?? "Desconocido";

        IHero hero = new Hero(heroName);

        Console.WriteLine("Selecciona 4 items para llevar a tu aventura");

        var pack = new InitialItems();
        var availableItems = pack.Initial;

        List<Item> initialItems = new List<Item>();
        while (initialItems.Count < 4)
        {
            for (int i = 0; i < availableItems.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {availableItems[i].GetType().Name}");
            }

            Console.Write($"Elige un item (Llevas {initialItems.Count} de 4): ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int selectedIndex))
            {
                int itemIndex = selectedIndex - 1;

                if (itemIndex >= 0 && itemIndex < availableItems.Count)
                {
                    Item selectedItem = availableItems[itemIndex];
                    initialItems.Add(selectedItem);
                    Console.WriteLine($"Elegiste: {selectedItem.GetType().Name}!");
                }
                else
                {
                    Console.WriteLine("Opción inválida. Elige un número de la lista.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
            }
            Console.WriteLine("-----------------------------");
        }


        hero.Inventary = initialItems;
        return hero;
    }
}