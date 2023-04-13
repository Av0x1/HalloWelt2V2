namespace HalloWelt2V2.Classes
{
	public class IOManager
	{
		public Int32 ValidateInputNumber()
		{
			Int32 output;

			while (!Int32.TryParse(Console.ReadLine(), out output) || !AgeIsAboveZero(output))
			{
				Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
			}

			return output;
		}

		public Genders GetUserGender()
		{
			ConsoleKey inputGender = this.ValidateInputGender(Console.ReadKey(true));

			if (inputGender.Equals(ConsoleKey.M))
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				return Genders.Male;
			}
			else if (inputGender.Equals(ConsoleKey.W))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				return Genders.Female;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Magenta;
				return Genders.NonBinary;
			}
		}

		public Int32 CheckIfAgeIsValid(Int32 age)
		{
			if (age < 18)
			{
				Console.WriteLine("\nEs tut mir leid. Du bist zu jung um dieses Programm nutzen zu dürfen. Dieses Programm ist ab 18 Jahren.\n");
				Console.ReadKey();
				Environment.Exit(0);
			}
			else if (age >= 18)
			{
				Console.WriteLine("\nDu bist alt genug.");
			}

			return age;
		}

		public Boolean ChooseCatOrDog()
		{
			ConsoleKey inputDecision = this.ValidateInputCatOrDog(Console.ReadKey(true));

			if(inputDecision.Equals(ConsoleKey.H))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		private Boolean AgeIsAboveZero(Int32 age)
		{
			if (age < 0)
			{
				return false;
			}

			return true;
		}

		private ConsoleKey ValidateInputGender(ConsoleKeyInfo input)
		{
			while (!input.Key.Equals(ConsoleKey.M) && !input.Key.Equals(ConsoleKey.W) && !input.Key.Equals(ConsoleKey.D))
			{
				Console.WriteLine("Bitte drücken Sie eine der folgenden Tasten:\n\"M\" für männlich.\n\"W\" für weiblich.\n\"D\" für divers.");
				input = Console.ReadKey(true);
			}

			return input.Key;
		}

		private ConsoleKey ValidateInputCatOrDog(ConsoleKeyInfo input)
		{
			while (!input.Key.Equals(ConsoleKey.H) && !input.Key.Equals(ConsoleKey.K))
			{
				Console.WriteLine("Bitte drücken Sie eine der folgenden Tasten:\n\"H\" für Hund.\n\"K\" für Katze.");
				input = Console.ReadKey(true);
			}

			return input.Key;
		}
	}
}
