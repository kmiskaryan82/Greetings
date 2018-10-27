using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
	class Program
	{
		static void Main(string[] args)
		{
			Mard mard1 = new Positive();
			Mard mard2 = new Positive();
			Mard mard3 = new Himar();
			Mard mard4 = new Realist();
			Mard mard5 = new Himar();

			Random rnd = new Random();
			string[] names = new string[] { "Alex", "Aram", "Anahit", "Irina", "Narine", "Armen", "Hayk", "Silva", "Sanasar" };

			List<Mard> mardiq = new List<Mard>();

			mardiq.Add(mard1);
			mardiq.Add(mard2);
			mardiq.Add(mard3);
			mardiq.Add(mard4);
			mardiq.Add(mard5);

			for (int i = 0; i < mardiq.Count; i++)
			{
				mardiq[i].Name = names[rnd.Next(0, names.Length)];
				mardiq[i].Age = rnd.Next(20, 40);
			}

			for (int i = 0; i < mardiq.Count; i++)
			{
				for (int j = i + 1; j < mardiq.Count; j++)
				{
					Console.WriteLine(mardiq[i].Barevel(mardiq[j]));
					Console.WriteLine(mardiq[j].Barevel(mardiq[i]));
					Console.WriteLine("-----------");
				}
			}
			Console.ReadLine();
		}
	}
}
