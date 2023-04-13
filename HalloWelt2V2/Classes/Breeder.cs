namespace HalloWelt2V2.Classes
{
	public class Breeder
	{
		public List<Dog> dogs = new List<Dog>()
		{
			new Dog()
			{
				Name = "Coco",
				Age = 4,
				Gender = Genders.Male,
				Breed = DogBreeds.Husky,
				FurColour = "Weiß und Schwarz"
			},
			new Dog()
			{
				Name = "Sina",
				Age = 8,
				Gender = Genders.Female,
				Breed = DogBreeds.GoldenRetriever,
				FurColour = "Gold"
			},
			new Dog()
			{
				Name = "Bello",
				Age = 1,
				Gender = Genders.Male,
				Breed = DogBreeds.Dachshund,
				FurColour = "Braun"
			}
		};

		public List<Cat> cats = new List<Cat>()
		{
			new Cat()
			{
				Name = "Rolf",
				Age = 13,
				Gender = Genders.Male,
				Breed = CatBreeds.Siamese,
				FurColour = "Weiß"
			},
			new Cat()
			{
				Name = "Lucky",
				Age = 7,
				Gender = Genders.Female,
				Breed = CatBreeds.PersianCat,
				FurColour = "Gold gestreift"
			},
			new Cat()
			{
				Name = "Tom",
				Age = 2,
				Gender = Genders.Male,
				Breed = CatBreeds.BengalCat,
				FurColour = "Getigert"
			}
		};

		public void PresentDogs()
		{
			Int32 counter = 1;
			
			foreach (Dog dog in this.dogs)
			{
				if (dog.Gender.Equals(Genders.Male))
				{
					Console.WriteLine($"{counter} Das hier ist {dog.Name}. Er ist ein Rüde und {dog.Age} Jahre alt. Er ist ein {dog.Breed} und sein Fell ist {dog.FurColour}.\n");
				}
				else
				{
					Console.WriteLine($"{counter} Das hier ist {dog.Name}. Sie ist eine Hündin und {dog.Age} Jahre alt. Sie ist eine {dog.Breed} und ihr Fell ist {dog.FurColour}.\n");
				}

				counter++;
			}
		}

		public void PresentCats()
		{
			Int32 counter = 1;

			foreach (Cat cat in this.cats)
			{
				if (cat.Gender.Equals(Genders.Male))
				{
					Console.WriteLine($"{counter} Das hier ist {cat.Name}. Er ist ein Kater und {cat.Age} Jahre alt. Er ist ein {cat.Breed} und sein Fell ist {cat.FurColour}.\n");
				}
				else
				{
					Console.WriteLine($"{counter} Das hier ist {cat.Name}. Sie ist eine Katze und {cat.Age} Jahre alt. Sie ist eine {cat.Breed} und ihr Fell ist {cat.FurColour}.\n");
				}

				counter++;
			}
		}
		
		public Animal ChooseAnimal(Int32 animalNumber, IEnumerable<Animal> chosenAnimalSpeciesList)
		{
			Animal chosenAnimal = chosenAnimalSpeciesList.ElementAt(animalNumber - 1);

			return chosenAnimal;
		}

		public void LetAnimalDoSomething(Animal chosenAnimal)
		{
			Random random = new Random();
			Int32 randomNumber = random.Next(0, 2);
			
			if (chosenAnimal.GetType().Equals(typeof(Dog)))
			{
				Dog dog = (Dog)chosenAnimal;

				if (randomNumber.Equals(0))
				{
					dog.LetDogBark();
				}
				else if (randomNumber.Equals(1))
				{
					dog.LetDogGrowl();
				}
				else
				{
					dog.LetDogLick();
				}
			}
			else
			{
				Cat cat = (Cat)chosenAnimal;

				if (randomNumber.Equals(0))
				{
					cat.LetCatMeow();
				}
				else if (randomNumber.Equals(1))
				{
					cat.LetCatHiss();
				}
				else
				{
					cat.LetCatPurr();
				}
			}
		}
	}
}