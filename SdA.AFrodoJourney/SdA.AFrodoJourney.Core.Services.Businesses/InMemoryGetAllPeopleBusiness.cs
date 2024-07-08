using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Core.Services.Businesses
{
	public class InMemoryGetAllPeopleBusiness : IGetAllPeopleBusiness
	{
		public List<Person> GetAll()
		{
			return new List<Person>()
			{
				new Person() { Id = 1, Surname = "Frodon" },
				new () { Id = 2, Surname = "Sam" },
				new () { Id = 3, Surname = "Gimli" },
			};
		}
	}
}
