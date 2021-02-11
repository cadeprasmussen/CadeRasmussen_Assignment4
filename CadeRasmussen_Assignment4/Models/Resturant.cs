using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRasmussen_Assignment4.Models
{
    public class Resturant
    {

        //Constructor for the resturant model
        Resturant(int rank)
        {
            ResturantRank = rank;
        }

        [Required]
        //Rank is only readable and can not be altered once the rank has been entered
        public int? ResturantRank { get;}

        [Required]
        public string ResturantName { get; set; }

        public string FavroiteDish { get; set; } = "It's all tasty!";

        [Required]
        public string ResturantAddress { get; set; }

        //Getting a fromated phone number from the user. 
        [RegularExpression(@"^\(?([0-9]{3}-)\)?[-. ]?([0-9]{3}-)[-. ]?([0-9]{4})$", ErrorMessage = "Phone Number must be entered in xxx-xxx-xxxx format!")]
        public string ResturantPhone { get; set; }

        public string ResturantWebLink { get; set; } = "Coming soon.";

        /*Adding the the hard coded resturant information to be dispalyed on the home page.  */
        public static Resturant[] GetResturants()
        {
            Resturant r1 = new Resturant(1)
            {
                ResturantName = "Betos",
                ResturantAddress = "1314 N State St, Provo, UT 84604",
                FavroiteDish = "Carne Asada Fries Buritto",
                ResturantPhone = "(385) 223-8056",
                ResturantWebLink = "http://www.betosmexicanfood.com/"
            };

            Resturant r2 = new Resturant(2)
            {
                ResturantName = "Maria Bonitas",
                ResturantAddress = "3815 167 W 800 N, Orem, UT 84057",
                ResturantPhone = "(801) 426-9328",
                ResturantWebLink = "https://www.mariabonitagrill.com/"
            };

            Resturant r3 = new Resturant(3)
            {
                ResturantName = "Tepanyaki",
                ResturantAddress = "777 E University Pkwy, Orem, UT 84097",
                ResturantPhone = "(801) 960-9395",
                ResturantWebLink = "http://www.my-tepanyaki.com/"
            };

            Resturant r4 = new Resturant(4)
            {
                ResturantName = "Texas Roadhouse",
                ResturantAddress = "1265 S State St, Orem, UT 84097",
                ResturantPhone = "(801) 226-2742",
                ResturantWebLink = "http://www.betosmexicanfood.com/"
            };

            Resturant r5 = new Resturant(5)
            {
                ResturantName = "MidiCi",
                ResturantAddress = "541 E University Pkwy B, Orem, UT 84097",
                FavroiteDish = "Meat Lovers Pizza",
                ResturantPhone = "(385) 352-3752",
                ResturantWebLink = "http://www.mymidici.com/locations/utah/orem/orem/"
            };


            return new Resturant[] { r1, r2, r3, r4, r5 };
        }
    }
}
