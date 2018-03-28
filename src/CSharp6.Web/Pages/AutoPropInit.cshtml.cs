using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp6.Web.Pages
{
    public class AutoPropInitModel : PageModel
    {
        public string RunDemo()
        {
            var viq = new AutoPropPerson();
            return $"AutoPropPerson: {viq.FirstName} {viq.LastName}";
        }

        public class AutoPropPerson
        {
            public AutoPropPerson()
            {
                FirstName = "Viq";
            }

            public string FirstName { get; }
            public string LastName { get; set; } = "Smith";
        }
    }
}