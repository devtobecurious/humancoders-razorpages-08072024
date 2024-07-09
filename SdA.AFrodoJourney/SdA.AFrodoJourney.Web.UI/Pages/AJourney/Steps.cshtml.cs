using Microsoft.AspNetCore.Mvc.RazorPages;
using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Web.UI.Pages.AJourney
{
	public class StepsModel(IGetOneJourneyBusiness business) : PageModel
	{
		public void OnGet()
		{
			this.Journey = business.GetOneWithSteps();
		}

		public Journey Journey { get; private set; }
	}
}
