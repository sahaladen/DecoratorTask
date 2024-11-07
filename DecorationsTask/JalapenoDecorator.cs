using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationsTask
{
	public class JalapenoDecorator : ToppingDecorator
	{
		public JalapenoDecorator(Pizza original) : base(original)
		{

		}

		public override string GetDescription()
		{
			return base.GetDescription() + " with jalapeno";
		}
		public override double GetPrice()
		{
			return base.GetPrice() + 2.0;
		}
	}
}
