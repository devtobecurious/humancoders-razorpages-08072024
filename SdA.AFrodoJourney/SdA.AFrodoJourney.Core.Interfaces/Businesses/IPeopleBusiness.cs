using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Core.Interfaces.Businesses
{
	public interface IGetAllPeopleBusiness
	{
		List<Person> GetAll();
	}
}
