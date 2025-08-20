using MiJuego.Interface;

public class BattleSystem
{
    public BattleSystem(IHero hero, IMonster monster)
    {
        Console.WriteLine($"Te enfrentas a un {monster.Name}!");

        while (hero.Health > 0 && monster.Health > 0)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Presione 1 para atacar.");
            Console.WriteLine("Presione 2 para abrir inventario.");
            Console.WriteLine("Presione 3 para ver detalles.");
            string? option = Console.ReadLine();

            if (option == "1")
            {
                int damage = hero.Attack - monster.Defense;
                if (damage < 0) damage = 0;
                monster.Health -= damage;
                Console.WriteLine($"Hiciste {damage} de daño al {monster.Name}.");
                Console.WriteLine($"🧙‍♂️ Heroe: {hero.Health} HP | 👾 {monster.Name}: {monster.Health} HP");
                if (monster.Health > 0)
                {
                    int damageReceived = monster.Attack - hero.Defense;
                    if (damageReceived < 0) damageReceived = 0;
                    hero.Health -= damageReceived;
                    Console.WriteLine($"Recibiste {damageReceived} de daño.");
                }

            }

            if (option == "2")
            {
                Console.WriteLine("Seleccion el item");
                for (int i = 0; i < hero.Inventary.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {hero.Inventary[i].Name}");

                }
                string input = Console.ReadLine();
                if (int.TryParse(input, out int index))
                {
                    int indexSelect = index - 1;

                    for (int i = 0; i < hero.Inventary.Count; i++)
                    {
                        if (indexSelect == i)
                        {
                            hero.Inventary[indexSelect].Use(hero, monster);
                            hero.Inventary.Remove(hero.Inventary[indexSelect]);
                              int damageReceived = monster.Attack - hero.Defense;
                    if (damageReceived < 0) damageReceived = 0;
                    hero.Health -= damageReceived;
                    Console.WriteLine($"Recibiste {damageReceived} de daño.");

                        }

                    }
                }

                else
                {
                    Console.WriteLine("Valor invalido.");

                }

            }
            if (option == "3")
            {
            Console.WriteLine("----------Detalle del Heroe-----------");

                hero.ShowStats();
                Console.WriteLine("---------Detalle del Monstruo----------");
                monster.ShowStats();

             }
        }


        if (hero.Health > 0)
        {
            Console.WriteLine($"✅ Venciste al {monster.Name}.");
            
        }

        monster.ShowStats();
    }
}
