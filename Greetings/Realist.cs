using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
	public class Realist : Mard
	{
		public override string Barevel(Mard mard)
		{
			if (Age <= 5)
				return "Barev " + mard.Name;

			else
				return "Voxjuyn!!! " + mard.Name;
		}
	}
}
