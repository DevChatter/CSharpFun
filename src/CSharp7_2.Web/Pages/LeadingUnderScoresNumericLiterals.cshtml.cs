using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7_2.Web.Pages
{
    public class LeadingUnderScoresNumericLiteralsModel : PageModel
    {
        public string GetOldBinaryLiteral()
        {
            int oldWay = 0b0111_1110;

            return $"oldWay(0b0111_1110):{oldWay}";
        }
        public string GetNewBinaryLiteral()
        {
            int newWay = 0b_0111_1110;

            return $"newWay(0b_0111_1110):{newWay}";
        }

        public string GetOldHexLiteral()
        {
            int oldWay = 0xF0_F0_F0;

            return $"oldWay(0xF0_F0_F0):{oldWay}";
        }
        public string GetNewHexLiteral()
        {
            int newWay = 0x_F0_F0_F0;

            return $"newWay(0x_F0_F0_F0):{newWay}";
        }
    }
}