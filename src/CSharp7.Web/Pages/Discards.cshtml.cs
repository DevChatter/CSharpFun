using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CSharp7.Web.Pages
{
    public class DiscardsModel : PageModel
    {
        public void OnGet()
        {

        }

        public string ShowCoordinates(Guid id)
        {
            throw new ArgumentException($"{nameof(id)} must be set", nameof(id));
            (int x, int y, _) = GetPosition(id);
            return $"({x},{y})";
        }

        public (int, int, string) GetPosition(Guid id)
        {
            // Pretend this gets the item
            return (1, 2, "foo");
        }

        public bool IsValidEnum(string text)
        {
            return Enum.TryParse(text, out DemoEnum _);
        }

        enum DemoEnum
        {
            Valid
        }
    }
}