/*
 * Author: Amy Neeland
 * Class: SailorSoda.cs
 * Purpose: This class represents the Sailor Soda item
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// The Sailor Soda item
    /// </summary>
    public class SailorSoda: Drink, IOrderItem
    {
        /// <summary>
        /// gets the items price depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    case Size.Large:
                        return 2.07;
                    default:
                        throw new NotImplementedException($"Unknown size of (Size)");
                }
            }
        }

        /// <summary>
        /// gets item calories depending on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Large:
                        return 205;
                    default:
                        throw new NotImplementedException($"Unknown size of (Size)");
                }
            }
        }

        /// <summary>
        /// get the value of ice and sets the default value to true
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// get the value of soda flavor and sets the default value to cherry
        /// </summary>
        public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

        /// <summary>
        ///  get list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return ($"{Size} {Flavor} Sailor Soda");
        }

    }
}
