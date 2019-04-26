using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp8.Web.Pages
{
    public class StaticLocalFunctionsModel : PageModel
    {
        private const int myRadius = 25;

        public double GetCurrentArea()
        {
            double area = CalcArea(myRadius);
            return area;

            static double CalcArea(int r) => Math.PI * r * r;
        }
    }
}