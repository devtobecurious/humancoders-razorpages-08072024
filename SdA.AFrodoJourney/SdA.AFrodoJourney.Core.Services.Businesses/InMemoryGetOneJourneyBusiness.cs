using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Core.Services.Businesses
{
	public class InMemoryGetOneJourneyBusiness : IGetOneJourneyBusiness
	{
		public Journey GetOneWithSteps()
		{
			Journey aJourney = new(new Step() { CurrentLocation = new() { Id = 1, Label = "La comté " } },
											new Step() { CurrentLocation = new() { Id = 2, Label = "Moriah" } },
											new Step() { CurrentLocation = new() { Id = 3, Label = "Minas tirith" }, MeetPerson = new Person() { Id = 1, Surname = "Gimli" } });

			return aJourney;
		}
	}
}
