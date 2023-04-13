using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt2V2.Classes
{
	public class Cat : Animal
	{
		public CatBreeds Breed { get; set; }
		public String FurColour { get; set; }

		public Cat() { }

		public void LetCatMeow()
		{
			Console.WriteLine($"{this.Name} miaut.");
		}

		public void LetCatHiss()
		{
			Console.WriteLine($"{this.Name} faucht!");
		}

		public void LetCatPurr()
		{
			Console.WriteLine($"{this.Name} schnurrt!");
		}
	}
}
