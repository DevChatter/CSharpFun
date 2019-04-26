using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp8.Web.Pages
{
    public class PropertyPatternsModel : PageModel
    {
        public void OnGet()
        {

        }

        public static Receipt HandleConferenceSale(Conference conference)
        {
            return conference switch
            {
                { State: "OH", Name: "StirTrek" } => BuyNow(conference),
                { State: "OH" } => BuyTicket(conference),
                { State: "FL" } => RandomChoice(conference),
                { State: "WA" } => RandomChoice(conference),
                { State: "CA" } => RandomChoice(conference),
                _ => Receipt.None
            };
        }

        private static Receipt RandomChoice(Conference conference)
        {
            throw new NotImplementedException();
        }

        private static Receipt BuyTicket(Conference conference)
        {
            throw new NotImplementedException();
        }

        private static Receipt BuyNow(Conference conference)
        {
            throw new NotImplementedException();
        }
    }

    public class Conference
    {
        public string Name { get; set; }
        public string State { get; set; }
    }

    public class Receipt
    {
        public static Receipt None { get; internal set; }
    }
}