using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpeedMeasuremetRazor.Interfaces;
using SpeedMeasuremetRazor.Models;

namespace SpeedMeasuremetRazor.Pages.Locations
{
    public class CreateLocationModel : PageModel
    {
        private ILocationRepo locationRepo;

        [BindProperty]
        public Location Location { get; set; }

        public CreateLocationModel(ILocationRepo locations)
        {
            locationRepo = locations;
        }

        public void OnGet()
        {
            //return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            locationRepo.AddLocation(Location);

            return RedirectToPage("/Locations/Index");

        }

    }
}
