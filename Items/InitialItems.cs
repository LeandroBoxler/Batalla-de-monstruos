public class InitialItems
{
   public List<Item> Initial { get; set; } = new List<Item>();

   Item fireball = new FireBall();
Item healthPotion = new HealthPotion();
Item rainScroll = new RainScroll();
Item oilBomb = new OilBomb();
    
     public InitialItems()
    {
        Initial.AddRange(new List<Item> { fireball, healthPotion, rainScroll, oilBomb });
    }

    
}