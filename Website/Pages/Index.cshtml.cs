/*
 * *Author: Amy Neeland
 *Class name: IndexModel.cshtml.cs
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Entrees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<IOrderItem> Items { get; set; }

        public string SearchTerms { get; set; }

        public string[] ItemCategories { get; set; }

        /// <summary>
        /// gets the list of entrees available
        /// </summary>
        public IEnumerable<IOrderItem> Entrees {get { return Menu.Entrees(); } }

        /// <summary>
        /// gets the list of sides available
        /// </summary>
        public IEnumerable<IOrderItem> Sides { get { return Menu.Sides(); } }

        /// <summary>
        /// gets the list of drinks available
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get { return Menu.Drinks(); } }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] ItemCategories, uint CalorieMin, uint CalorieMax, 
            double PriceMin, double PriceMax)
        {
            Items = Menu.FullMenu();

            //filter by term
            if(SearchTerms != null)
            {
                Items = Items.Where(item => item.Name != null && 
                item.Name.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || 
                item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            /*if (SearchTerms != null)
            {
                Items = Menu.Search(SearchTerms.ToLower());
            }*/

            //filter by item type
            if(ItemCategories != null && ItemCategories.Length != 0)
            {
                Items = Items.Where(item => ItemCategories.Contains(item.ItemType));                
            }

            //Items = Menu.FilterByCategory(Items, ItemCategories);
            Items = Menu.FilterByCalories(Items, CalorieMin, CalorieMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            
        }
    }
}
