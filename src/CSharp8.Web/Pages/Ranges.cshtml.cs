using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp8.Web.Pages
{
    public class RangesModel : PageModel
    {
        public int[] Numbers { get; set; } = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public void OnGet()
        {
        }
    }
}