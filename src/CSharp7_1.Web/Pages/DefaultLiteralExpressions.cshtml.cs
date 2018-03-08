using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7_1.Web.Pages
{
    public class DefaultLiteralExpressionsModel : PageModel
    {
        public string GetStringValue()
        {
            string oldWay = default(string);

            string newWay = default;

            return oldWay == newWay
                ? "\"string oldWay = default(string)\" and \"string newWay = default;\" are the same"
                : "This shouldn't happen...";
        }
    }
}