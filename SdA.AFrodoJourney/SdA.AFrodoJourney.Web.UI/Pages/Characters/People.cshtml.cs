using Microsoft.AspNetCore.Mvc.RazorPages;
using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Web.UI.Pages.Characters
{
	public class PeopleModel : PageModel
	{
		private readonly IGetAllPeopleBusiness business;

		public PeopleModel(IGetAllPeopleBusiness business)
		{
			this.business = business;
		}

		public void OnGet()
		{
			this.PersonList = this.business.GetAll();
			//this.PersonList = new List<Person>()
			//{
			//	new Person() { Id = 1, Surname = "Frodon" },
			//	new () { Id = 2, Surname = "Sam" },
			//	new () { Id = 3, Surname = "Gimli" },
			//};
		}

		#region Properties
		public List<Person> PersonList { get; private set; }
		#endregion
	}
}
