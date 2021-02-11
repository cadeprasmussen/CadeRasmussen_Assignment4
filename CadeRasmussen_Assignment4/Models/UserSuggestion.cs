using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRasmussen_Assignment4.Models
{
    public class UserSuggestion
    {
        public string UserName { get; set; } = "Withheld";

        [Required]
        public string ResturantName { get; set; }
        public string FavoriteDish { get; set; } = "It's all tasty!";

        //Making sure that the phone numbers are in a correct format
        [RegularExpression(@"^\(?([0-9]{3}-)\)?[-. ]?([0-9]{3}-)[-. ]?([0-9]{4})$", ErrorMessage = "Phone Number must be entered in xxx-xxx-xxxx format!")]
        public string RestPhone { get; set; }
    }
}
