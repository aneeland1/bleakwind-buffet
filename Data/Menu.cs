/*
 * Author: Amy Neeland
 * Class: Menu.cs
 * Purpose: Contains collections of all the entrees, drinks, and sides
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for collection of entrees, drinks, sides and full menu
    /// </summary>
    public static class Menu
    {
        private static List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Gets the item categories
        /// </summary>
        public static string[] ItemCategories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink",
            };
        }

        /// <summary>
        /// Collection of the entree items in an IEnumerable
        /// </summary>
        /// <returns>list of entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new BriarheartBurger());
            items.Add(new DoubleDraugr());
            items.Add(new GardenOrcOmelette());
            items.Add(new PhillyPoacher());
            items.Add(new SmokehouseSkeleton());
            items.Add(new ThalmorTriple());
            items.Add(new ThugsTBone());

            return items;
        }

        /// <summary>
        /// Collection of the side items in an IEnumerable
        /// </summary>
        /// <returns>list of sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new DragonbornWaffleFries() { Size = Size.Large });
            items.Add(new DragonbornWaffleFries() { Size = Size.Medium });
            items.Add(new DragonbornWaffleFries() { Size = Size.Small });
            items.Add(new FriedMiraak() { Size = Size.Large });
            items.Add(new FriedMiraak() { Size = Size.Medium });
            items.Add(new FriedMiraak() { Size = Size.Small });
            items.Add(new MadOtarGrits() { Size = Size.Large });
            items.Add(new MadOtarGrits() { Size = Size.Medium });
            items.Add(new MadOtarGrits() { Size = Size.Small });
            items.Add(new VokunSalad() { Size = Size.Large });
            items.Add(new VokunSalad() { Size = Size.Medium });
            items.Add(new VokunSalad() { Size = Size.Small });

            return items;
        }

        /// <summary>
        /// Collection of the drink items in an IEnumerable
        /// </summary>
        /// <returns>List of drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new AretinoAppleJuice() { Size = Size.Large });
            items.Add(new AretinoAppleJuice() { Size = Size.Medium });
            items.Add(new AretinoAppleJuice() { Size = Size.Small });
            items.Add(new CandlehearthCoffee() { Size = Size.Large });
            items.Add(new CandlehearthCoffee() { Size = Size.Medium });
            items.Add(new CandlehearthCoffee() { Size = Size.Small });
            items.Add(new CandlehearthCoffee() { Size = Size.Large, Decaf = true });
            items.Add(new CandlehearthCoffee() { Size = Size.Medium, Decaf = true });
            items.Add(new CandlehearthCoffee() { Size = Size.Small, Decaf = true });
            items.Add(new MarkarthMilk() { Size = Size.Large });
            items.Add(new MarkarthMilk() { Size = Size.Medium });
            items.Add(new MarkarthMilk() { Size = Size.Small });
            items.Add(new WarriorWater() { Size = Size.Large });
            items.Add(new WarriorWater() { Size = Size.Medium });
            items.Add(new WarriorWater() { Size = Size.Small });
            items.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Blackberry });
            items.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Blackberry });
            items.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Blackberry });
            items.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Cherry });
            items.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Cherry });
            items.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Cherry });
            items.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Grapefruit });
            items.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Grapefruit });
            items.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Grapefruit });
            items.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Lemon });
            items.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Lemon });
            items.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Lemon });
            items.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Peach });
            items.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Peach });
            items.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Peach });
            items.Add(new SailorSoda() { Size = Size.Large, Flavor = SodaFlavor.Watermelon });
            items.Add(new SailorSoda() { Size = Size.Medium, Flavor = SodaFlavor.Watermelon });
            items.Add(new SailorSoda() { Size = Size.Small, Flavor = SodaFlavor.Watermelon });

            return items;
        }

        /// <summary>
        /// Collection of all items in an IEnumerable
        /// </summary>
        /// <returns>list of all items</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> all = new List<IOrderItem>();
            all.AddRange(Entrees());
            all.AddRange(Sides());
            all.AddRange(Drinks());

            return all;
        }

        /// <summary>
        /// searches for terms in a list of items
        /// </summary>
        /// <param name="terms">term to find</param>
        /// <returns>list of items containing the term</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (terms == null) return FullMenu();

            foreach (IOrderItem item in FullMenu())
            {
                //Add the item if there is a match
                if (item.Name != null && item.Name.ToLower().Contains(terms))
                {
                    results.Add(item);
                }                
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="items">The collection of menu items to filter</param>
        /// <param name="categories">The categories to include</param>
        /// <returns>A collection containing only menu items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            // If no filter is specified, just return the provided collection
            if (categories == null || categories.Count() == 0) return items;

            // Filter the supplied collection items based on the supplied categories
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (string cat in categories)
            {
                if(cat=="Entree")
                {
                    results.AddRange(Entrees());    
                }
                if(cat=="Side")
                {
                    results.AddRange(Sides());
                }
                if (cat == "Drink")
                {
                    results.AddRange(Drinks());
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection
        /// to those with Calories falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered movie collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if ((min == null && max == null) || (min==0 && max ==0)) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }

        /// <summary>
        /// Filters the provided collection
        /// to those with a price falling within
        /// the specified range
        /// </summary>
        /// <param name="items">The collection of menu items to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null || min== 0 && max == 0) return items;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null || min == 0)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null || max == 0)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }

    }
}
