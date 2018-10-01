using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7_3.Web.Pages
{
    public class EnumConstraintModel : PageModel
    {
        public void OnGet()
        {

        }

private string GetName<T>(T obj) where T : System.Enum
{
    return System.Enum.GetName(obj.GetType(), obj);
}
    }

    public enum MyEnum
    {
        Zero,
        One,
        Two,
        Three
    }
}