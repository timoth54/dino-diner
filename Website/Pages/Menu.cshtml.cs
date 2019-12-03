using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; } = new Menu();

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();

        [BindProperty]
        public double minimumPrice { get; set; } = 0;

        [BindProperty]
        public double maximumPrice { get; set; } = 10;

        [BindProperty]
        public List<string> excludeIngredient { get; set; } = new List<string>();

        public void OnGet()
        { 
        }

        public void OnPost()
        {
            Menu menu = new Menu();
        }
    }
}
