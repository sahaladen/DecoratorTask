using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace DecorationsTask
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Pizza margerithaPizza = new PlainPizza(10.0);
			Pizza chickenPizza = new ChickenPizza(15.0);
			Pizza jalapenoPizza = new JalapenoDecorator(margerithaPizza);
			Pizza chickenPizzaWithbiff = new BiffDecoration(chickenPizza);
			PrintPizzaInfo(margerithaPizza);
			PrintPizzaInfo(jalapenoPizza);
			PrintPizzaInfo(chickenPizza);
			PrintPizzaInfo(chickenPizzaWithbiff);
		}
		
		private static void PrintPizzaInfo(Pizza pizza)
		{
			Console.WriteLine($"{pizza.Name}{pizza.GetDescription()}");
			Console.WriteLine($"{pizza.GetPrice()}");

		}
	}
}
