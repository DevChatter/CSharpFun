using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp8.Web.Pages
{
    public class NullForgivingModel : PageModel
    {
        public void OnGet()
        {

        }
    }

#nullable enable
    public class Person
    {
        public string FirstName;
        public string? MiddleName;
        public string LastName;

        public Person() // Warning: Must set FirstName, LastName
        {
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int GetMiddleNameLength()
        {
            // Bad Code: Don't do this!
            return MiddleName!.Length;
        }
    }
#nullable disable
}