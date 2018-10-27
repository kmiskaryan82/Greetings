using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
	public abstract class Mard
	{

		public string Name;
		public int Age;

		public virtual string Barevel(Mard name)
		{
			return "Barev " + name;
		}
	}
}
