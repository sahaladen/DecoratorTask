using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationsTask
{
	public class HamDecorator : ToppingDecorator
	{
		public HamDecorator(Pizza original): base(original) 
		{

		}
		public override string GetDescription()
		{
			return base.GetDescription() + " with ham";
		}
		public override double GetPrice()
		{
			return base.GetPrice() + 7.0;
		}

	}
}
