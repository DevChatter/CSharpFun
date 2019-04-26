using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp8.Web.Pages
{
    public class TuplePatternsModel : PageModel
    {
        public void OnGet()
        {

        }

        public static string GetResult(string choice1, string choice2)
        {
            return (choice1, choice2) switch
            {
                ("rock", "scissors") => "Rock crushes scissors.",
                ("paper", "rock") => "Paper covers rock.",
                ("scissors", "paper") => "Scissors cut paper.",
                ("rock", "paper") => "Paper covers rock.",
                ("paper", "scissors") => "Scissors cut paper.",
                ("scissors", "rock") => "Rock crushes scissors.",
                (_, _) => "Tie game." // can use _ instead of (_, _) if desired.
            };
        }
    }
}