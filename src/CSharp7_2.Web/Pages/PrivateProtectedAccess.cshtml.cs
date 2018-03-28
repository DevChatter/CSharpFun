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
        public void OnGet()
        {

        }
    }

    // Assembly1.cs  
    // Compile with: /target:library  
    public class BaseClass
    {
        private protected int myValue = 0;
    }

    public class DerivedClass1 : BaseClass
    {
        void Access()
        {
            BaseClass baseObject = new BaseClass();

            // Error CS1540, because myValue can only be accessed by
            // classes derived from BaseClass.
            // baseObject.myValue = 5;  

            // OK, accessed through the current derived class instance
            myValue = 5;
        }
    }
}