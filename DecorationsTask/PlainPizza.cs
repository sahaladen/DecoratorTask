using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DecorationsTask
{
	public class PlainPizza : Pizza
	{
		public PlainPizza(double price) : base("Margherita: ")
		{
			_description = "Tomato sauce, mozzarella, oregano";
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
