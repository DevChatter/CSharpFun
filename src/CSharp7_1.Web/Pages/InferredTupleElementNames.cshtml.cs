using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharp7_1.Web.Pages
{
    public class InferredTupleElementNamesModel : PageModel
    {
        public string OldWay()
        {
            int count = 5;
            string label = "Colors used in the map";
            var pair = (count: count, label: label);
            return $"var pair = (count: count, label: label) is pair.count:{pair.count} and pair.label:{pair.label}";
        }

        public string NewWay()
        {
            int count = 5;
            string label = "Colors used in the map";
            var pair = (count, label); // element names are "count" and "label"
            return $"var pair = (count, label) is pair.count:{pair.count} and pair.label:{pair.label}";
        }
    }
}