using CadeRasmussen_Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRasmussen_Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            if (ModelState.IsValid)
            {
                List<string> resturantList = new List<string>();

                foreach (Resturant r in Resturant.GetResturants())
                {
                    //Formating the string to be dispalyed inside of the webpage. 
                    resturantList.Add(string.Format("#{0}: {1} <br/> {2} <br/> {3} <br/> {4} <br/> <a href=\"{5}\" target=\"_blank\">Website</a>", r.ResturantRank, r.ResturantName, r.FavroiteDish, r.ResturantAddress, r.ResturantPhone, r.ResturantWebLink));
                };
                return View(resturantList);
            }
            else
            {
                return View();
            }
        }


        [HttpGet("Submit")]
        public IActionResult SubmitSuggestion()
        {
            return View();
        }

        [HttpPost("Submit")]
        public IActionResult SubmitSuggestion(UserSuggestion suggestion)
        {
            if (ModelState.IsValid)
            {
                //Making sure that the data that was passed is valid and if not returning the normal view with error message. If valid, adding the info the temp
                tempStorage.AddResturant(suggestion);
                return View("SuggestList", tempStorage.SuggestList);
            }
            else
            {
                return View();
            }
            
        }

        [HttpGet("List")]
        public IActionResult SuggestList()
        {
            //Passing the tempStorage data into the html page
            return View(tempStorage.SuggestList);
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
