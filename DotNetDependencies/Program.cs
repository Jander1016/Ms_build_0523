// See https://aka.ms/new-console-template for more information
using Humanizer;

Console.WriteLine("Hello, World!");

Console.WriteLine("Quantities");
HumanizerQuantity();

Console.WriteLine("\nDate/time Manipulation: ");
HumanizerDate();

static void HumanizerQuantity()
{
  Console.WriteLine("Case".ToQuantity(0));
  Console.WriteLine("Case".ToQuantity(1));
  Console.WriteLine("Case".ToQuantity(5)); 
}

static void HumanizerDate()
{
  Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
  Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
  Console.WriteLine(TimeSpan.FromDays(1).Humanize());
  Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}