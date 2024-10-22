namespace Decorator.Decorator;

public class BaseCafe : Cafe
{
    public override void GetCafe()
    {
        Console.WriteLine("Base Cafe");
    }
    
    public override int GetCafePrice()
    {
        return 4;
    }
}