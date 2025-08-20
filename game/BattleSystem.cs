using MiJuego.Interface;

public class BattleSystem
{
    private IHero hero;
    private IMonster monster;

    public BattleSystem(IHero hero, IMonster monster)
    {
        this.hero = hero;
        this.monster = monster;
        Console.WriteLine($"Te enfrentas a un {monster.Name}!");
    }

    // Método que inicia la batalla y devuelve true si el héroe gana
    public bool StartBattle()
    {
        while (hero.Health > 0 && monster.Health > 0)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Abrir inventario");
            Console.WriteLine("3 - Ver detalles");

            string? option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    Attack();
                    break;
                case "2":
                    UseItem();
                    break;
                case "3":
                    ShowDetails();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (hero.Health <= 0)
                break;
        }

        bool heroWon = hero.Health > 0;
        if(heroWon)
            Console.WriteLine($"✅ Venciste al {monster.Name}!");
        else
            Console.WriteLine("💀 Has sido derrotado...");

        return heroWon;
    }

    private void Attack()
    {
        int damage = hero.Attack - monster.Defense;
        if (damage < 0) damage = 0;
        monster.Health -= damage;
        Console.WriteLine($"Hiciste {damage} de daño al {monster.Name}.");

        if (monster.Health > 0)
        {
            int damageReceived = monster.Attack - hero.Defense;
            if (damageReceived < 0) damageReceived = 0;
            hero.Health -= damageReceived;
            Console.WriteLine($"Recibiste {damageReceived} de daño.");
        }

        Console.WriteLine($"🧙‍♂️ Heroe: {hero.Health} HP | 👾 {monster.Name}: {monster.Health} HP");
    }

    private void UseItem()
    {
        Console.WriteLine("Selecciona un item:");
        for (int i = 0; i < hero.Inventary.Count; i++)
            Console.WriteLine($"{i + 1} - {hero.Inventary[i].Name}");

        string? input = Console.ReadLine();
        if (int.TryParse(input, out int index))
        {
            int indexSelect = index - 1;
            if (indexSelect >= 0 && indexSelect < hero.Inventary.Count)
            {
                hero.Inventary[indexSelect].Use(hero, monster);
                hero.Inventary.RemoveAt(indexSelect);

                int damageReceived = monster.Attack - hero.Defense;
                if (damageReceived < 0) damageReceived = 0;
                hero.Health -= damageReceived;
                Console.WriteLine($"Recibiste {damageReceived} de daño.");
            }
            else Console.WriteLine("Valor invalido.");
        }
        else Console.WriteLine("Valor invalido.");
    }

    private void ShowDetails()
    {
        Console.WriteLine("-----------Detalle del Heroe---------------");
        hero.ShowStats();
        Console.WriteLine("-----------Detalle del Monstruo-------------");
        monster.ShowStats();
    }
}
