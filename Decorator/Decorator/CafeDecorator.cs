namespace Decorator.Decorator;

public class CafeDecorator(Cafe cafe) : Cafe
{
    public override void GetCafe()
    {
        cafe.GetCafe();
    }

    public override int GetCafePrice()
    {
        return cafe.GetCafePrice();
    }
}