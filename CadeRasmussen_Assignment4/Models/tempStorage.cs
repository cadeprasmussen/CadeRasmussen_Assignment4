using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRasmussen_Assignment4.Models
{
    public class tempStorage
    {
        private static List<UserSuggestion> UserSuggestion = new List<UserSuggestion>();
        public static IEnumerable<UserSuggestion> SuggestList => UserSuggestion;

        public static void AddResturant(UserSuggestion rest)
        {
            UserSuggestion.Add(rest);
        }
    }
}
