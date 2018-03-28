using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7_2.Web.Pages
{
    public class ReferenceSemanticsValueTypesModel : PageModel
    {
        private static BigStruct[] bigStructs = { new BigStruct {X = 1, Y = 2, Z = 3},  };
        public string GetInString()
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

        public string GetRefReturnString()
        {
            ref readonly BigStruct bigStruct = ref GetRefReturn();
            //bigStruct.X = 7; // compiler error
            string string1 = $" ({bigStruct.X} {bigStruct.Y} { bigStruct.Z}) ";
            UseBigStruct(bigStruct); // Passes a copy
            string string2 = $" ({bigStruct.X} {bigStruct.Y} { bigStruct.Z}) ";
            return string1 + string2;
        }

        private static ref readonly BigStruct GetRefReturn()
        {
            return ref bigStructs[0];
        }
        private static void UseBigStruct(BigStruct thing)
        {
            thing.X += 5;
        }
    }

    public struct BigStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }

    public readonly struct HeavilyPassedReadonlyStruct
    {
        public HeavilyPassedReadonlyStruct(Char symbol, int x, int y) 
            => (Symbol, X, Y) = (symbol, x, y);

        public Char Symbol { get; }
        public int X { get; }
        public int Y { get; }
    }
    public ref struct HeavilyPassedRefStruct
    {
        public HeavilyPassedRefStruct(Char symbol, int x, int y) 
            => (Symbol, X, Y) = (symbol, x, y);

        public Char Symbol { get; }
        public int X { get; }
        public int Y { get; }
    }
    public readonly ref struct HeavilyPassedReadonlyRefStruct
    {
        public HeavilyPassedReadonlyRefStruct(Char symbol, int x, int y) 
            => (Symbol, X, Y) = (symbol, x, y);

        public Char Symbol { get; }
        public int X { get; }
        public int Y { get; }
    }
}