using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7.Web.Pages
{
    public class TuplesModel : PageModel
    {
        private int _field1;
        private int _field2;
        private int _field3;
        public TuplesModel(int field1, int field2, int field3)
        {
            (_field1, _field2, _field3) = (field1, field2, field3);
        }

        public void OnGet()
        {

        }
    }

public class SpriteData
{
    public SpriteData((int, int) coordinates, string name)
    {
        (X, Y) = coordinates; // careful of order though!
        Name = name;
    }

    public int X { get; }
    public int Y { get; }
    public string Name { get; }
}
}