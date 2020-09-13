/*
 *Author: Amy Neeland
 * Class: AretinoAppleJuice.cs
 * Purpose: This class represents the Aretino Apple Juice item
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Arentino Apple Juice item
    /// </summary>
    public class AretinoAppleJuice: Drink, IOrderItem
    {   
        // <summary>
        /// gets the items price depending on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return .62;
                    case Size.Medium:
                        return .87;
                    case Size.Large:
                        return 1.01;
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
                switch (Size)
                {
                    case Size.Small:
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
                    default:
                        throw new NotImplementedException($"Unknown size of (Size)");
                }
            }
        }

        /// <summary>
        /// get the value of ice and sets the default value to false
        /// </summary>
        public bool Ice { get; set; } = false;

        // <summary>
        ///  get list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return ($"{Size} Aretino Apple Juice");
        }
    }
}
