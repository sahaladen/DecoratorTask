using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationsTask
{
	internal class BiffDecoration : ToppingDecorator
	{
		public BiffDecoration(Pizza original) : base(original)
		{ 
		}
		public override string GetDescription()
		{
			return base.GetDescription() + " with extra biff";
		}
		public override double GetPrice()
		{
			return base.GetPrice() + 5.0;
		}
	}

}
