using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7_2.Web.Pages
{
    public class PrivateProtectedAccessModel : PageModel
    {
        public string GetString()
        {
            var childClass = new ChildClass();
            childClass.ChangeTheValue();
            return childClass.GetText();
        }
    }

    public class ParentClass
    {
        private protected string text = "parent";
        public string GetText() => text;
    }

    public class ChildClass : ParentClass
    {
        public void ChangeTheValue()
        {
            base.text = "from child";
        }
    }
}