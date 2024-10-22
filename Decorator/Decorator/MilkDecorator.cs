namespace Decorator.Decorator;

public class MilkDecorator(Cafe cafe) : CafeDecorator(cafe)
{
    public override void GetCafe()
    {
        Console.WriteLine("Added Milk");
    }

    public override int GetCafePrice()
    {
        return base.GetCafePrice() + 1;
    }
}