using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7_2.Web.Pages
{
    public class NonTrailingNamedArgumentsModel : PageModel
    {
public string GetFullName()
{
    return Name("Brendan", middleName: "Danger", "Enrick");
}

        private string Name(string firstName, string middleName, string lastName)
        {
            return $"{firstName} {middleName} {lastName}";
        }

    }
}