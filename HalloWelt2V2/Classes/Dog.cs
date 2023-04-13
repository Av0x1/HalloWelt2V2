using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt2V2.Classes
{
	public class Dog : Animal
	{
		public DogBreeds Breed { get; set; }
		public String FurColour { get; set; }
		
		public void LetDogBark()
		{
			Console.WriteLine($"{this.Name} bellt.");
		}

		public void LetDogLick()
		{
			Console.WriteLine($"{this.Name} schleckt!");
		}

		public void LetDogGrowl()
		{
			Console.WriteLine($"{this.Name} knurrt!");
		}
	}
}