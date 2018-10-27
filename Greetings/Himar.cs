using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
	public class Himar : Mard
	{
		public override string Barevel(Mard mard)
		{
			return "Barev! " + mard.Name;
		}
	}
}
