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

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for collection of entrees, drinks, sides and full menu
    /// </summary>
    public static class Menu
    {
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
        
    }
}
