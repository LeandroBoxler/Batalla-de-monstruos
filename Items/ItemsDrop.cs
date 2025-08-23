public class ItemsDrop
{
   public List<Item> Drop { get; set; } = new List<Item>();

   Item fireball = new FireBall();
Item healthPotion = new HealthPotion();
Item rainScroll = new RainScroll();
    Item oilBomb = new OilBomb();
Item ThunderScroll = new ThunderScroll();

    public ItemsDrop()
    {
        Drop.AddRange(new List<Item> { fireball, healthPotion, rainScroll, oilBomb,ThunderScroll });

    }
    
}