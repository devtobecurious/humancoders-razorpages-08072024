using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SdA.AFrodoJourney.Core.Models;

namespace SdA.AFrodoJourney.Web.UI.Pages.Characters
{
    public class Test
    {
        public string Surname { get; set; }
    }

    public class AddModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                // Les contraintes de data annotations sont OK
            }
        }

        //[BindProperty]
        //public string Surname { get; set; }

        [BindProperty(SupportsGet = false)]
        // [Remote()]
        public Person ThePerson { get; set; }
        // public Test ThePerson { get; set; }
    }
}
