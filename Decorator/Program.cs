using Decorator.Decorator;

Cafe cafe = new BaseCafe();
Console.WriteLine($"{cafe.GetCafePrice()}");
cafe = new MilkDecorator(cafe);
Console.WriteLine($"{cafe.GetCafePrice()}");
cafe = new WhippedCreamDecorator(cafe);
Console.WriteLine($"{cafe.GetCafePrice()}");