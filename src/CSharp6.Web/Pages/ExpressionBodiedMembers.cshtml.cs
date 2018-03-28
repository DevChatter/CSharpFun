using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp6.Web.Pages
{
    public class ExpressionBodiedMembersModel : PageModel
    {
        public class StandardRectangle
        {
            public int Length { get; set; }
            public int Width { get; set; }
            public bool IsSquare() => Length == Width;
            public int Area => Length * Width;
            public void MakeSquare(int size) => Length = Width = size;
        }

        public static void RunDemo()
        {
            // TODO: Convert this
            Console.WriteLine("===Getting Square Rectanle===");
            var square = new StandardRectangle { Length = 6, Width = 6 };
            Console.WriteLine("Rectangle: " + square.Length + "x" + square.Width);
            Console.WriteLine("IsSquare() = " + square.IsSquare());
            Console.WriteLine("Area = " + square.Area);
            Console.WriteLine("===Getting NonSquare Rectangle===");
            var nonSquare = new StandardRectangle { Length = 8, Width = 6 };
            Console.WriteLine("Rectangle: " + nonSquare.Length + "x" + nonSquare.Width);
            Console.WriteLine("IsSquare() = " + nonSquare.IsSquare());
            Console.WriteLine("Area = " + nonSquare.Area);
            Console.WriteLine("===Changing NonSquare to Square===");
            nonSquare.MakeSquare(12);
            Console.WriteLine("Rectangle: " + nonSquare.Length + "x" + nonSquare.Width);
            Console.WriteLine("IsSquare() = " + nonSquare.IsSquare());
            Console.WriteLine("Area = " + nonSquare.Area);

        }
    }
}