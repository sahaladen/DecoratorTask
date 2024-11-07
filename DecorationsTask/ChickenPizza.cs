using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationsTask
{
	public class ChickenPizza : Pizza
	{
		public ChickenPizza(double price): base("chicken pizza: ")
		{
			_description = "white sauce, mozzarella, oregano, chicken";
			_price = price;
		}



		public override double GetPrice()
		{
			return _price;
		}
		public override string GetDescription()
		{
			return _description;
		}
	}
}
