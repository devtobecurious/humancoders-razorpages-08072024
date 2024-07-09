using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SdA.AFrodoJourney.Core.Interfaces.Businesses;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Web.UI.Pages.AJourney
{
    public class StepsModel(IGetOneJourneyBusiness business, SdA.AFrodoJourney.Core.Interfaces.Loggers.ILogger logger) : PageModel
    {
        public void OnGet()
        {
            this.StepList = business.GetOneWithSteps().Steps;
            this.LocationList = new List<Location>() { new Location() { Id = 1, Label = "Comté" }, new Location() { Id = 1, Label = "Moria" } };
            this.PersonList = new List<Person>() { new Person() { Id = 1, Surname = "Gandalf" }, new Person() { Id = 1, Surname = "Gollum" } };
        }
        public void OnPost()
        {
            this.StepList = business.GetOneWithSteps().Steps;
            this.StepList.Add(StepsJourney);
        }
        public List<Step> StepList { get; set; }

        [BindProperty]
        public Step StepsJourney { get; set; }

        [BindProperty]
        public string Test { get; set; }

        public List<Location> LocationList { get; set; }
        public List<Person> PersonList { get; set; }
    }
}

