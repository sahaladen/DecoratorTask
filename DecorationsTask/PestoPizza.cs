using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationsTask
{
	public class PestoPizza : Pizza
	{
		public PestoPizza(double price) : base("pesto pizza: ")
		{
			_description = "tomato sauce, mozzarella, oregano, pesto";
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
