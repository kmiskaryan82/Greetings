using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
	public class Positive : Mard
	{
		public override string Barevel(Mard mard)
		{
			return "Voxjuyn " + mard.Name;
		}
	}
}
