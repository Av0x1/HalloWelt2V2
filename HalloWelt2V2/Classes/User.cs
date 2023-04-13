using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt2V2.Classes
{
	public class User
	{
		private String userName;
		private Int32 userAge;
		private Genders userGender;

		List<Animal> animals = new List<Animal>();

		public User(String userName, Int32 userAge, Genders userGender)
		{
			this.userName = userName;
			this.userAge = userAge;
			this.userGender = userGender;
		}
	}
}
