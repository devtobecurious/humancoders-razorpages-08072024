using Microsoft.AspNetCore.Mvc.RazorPages;
using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Web.UI.Pages.AJourney
{
	public class StepsModel(IGetOneJourneyBusiness business, SdA.AFrodoJourney.Core.Interfaces.Loggers.ILogger logger) : PageModel
	{
		public void OnGet()
		{
			logger.Log("On get ");
			this.Journey = business.GetOneWithSteps();
		}

		public Journey Journey { get; private set; }
	}
}
