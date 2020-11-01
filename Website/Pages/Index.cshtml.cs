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

        public void OnGet()
        {

        }
    }
}
