using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7_2.Web.Pages
{
    public class ReferenceSemanticsValueTypesModel : PageModel
    {
        public string GetString()
        {
            int radius = 2;
            const int constRad = 3;
            double fromVar = CalculateArea(in radius);
            double fromConst = CalculateArea(constRad);
            double fromLiteral = CalculateArea(7);
            return $"{fromVar} {fromConst} {fromLiteral}";
        }

        private static double CalculateArea(in int radius)
        {
            return Math.PI * radius * radius;
        }
    }
}