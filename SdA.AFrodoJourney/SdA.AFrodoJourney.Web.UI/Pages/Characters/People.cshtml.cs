using Microsoft.AspNetCore.Mvc.RazorPages;
using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Web.UI.Pages.Characters
{
    public class PeopleModel(IGetAllPeopleBusiness business, SdA.AFrodoJourney.Core.Interfaces.Loggers.ILogger logger) : PageModel
    {
        //private readonly IGetAllPeopleBusiness business;

        //public PeopleModel(IGetAllPeopleBusiness business)
        //{
        //	this.business = business;
        //}

        public void OnGet()
        {
            logger.Log("On get people");

            this.PersonList = business.GetAll();

            this.LocationList = new()
            {
                new() { Id = 1, Label = "Comt�"},
                new() { Id = 2, Label = "Moriah"}
            };
        }

        #region Properties
        public List<Person> PersonList { get; private set; }

        public List<Location> LocationList { get; private set; }
        #endregion
    }
}
