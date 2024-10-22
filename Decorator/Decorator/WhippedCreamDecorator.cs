namespace Decorator.Decorator;

public class WhippedCreamDecorator(Cafe cafe) : CafeDecorator(cafe)
{
    public override void GetCafe()
    {
        Console.WriteLine("Added whipped cream");
    }

    public override int GetCafePrice()
    {
        return base.GetCafePrice() + 2;
    }
}