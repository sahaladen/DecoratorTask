using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationsTask
{
	public abstract class ToppingDecorator : Pizza
	{
		private readonly Pizza _originalPlainPizza;
		protected ToppingDecorator(Pizza original) : base(original.Name)
		{
			_originalPlainPizza = original;
		}

		public override double GetPrice()
		{
			return _originalPlainPizza.GetPrice();
		}
		public override string GetDescription()
		{
			return _originalPlainPizza.GetDescription();
		}
	}
}
