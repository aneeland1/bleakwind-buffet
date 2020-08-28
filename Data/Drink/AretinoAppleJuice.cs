/*
 *Author: Amy Neeland
 * Class: AretinoAppleJuice.cs
 * Purpose: This class represents the Aretino Apple Juice item
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drink
{
    public class AretinoAppleJuice
    {
        public Size Size { get; set; } = Size.Small;

        // <summary>
        /// gets the items price depending on size
        /// </summary>
        public double Price
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
        public uint Calories
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
        public bool Ice { get; set; } = true;

        // <summary>
        ///  get list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
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
            return ($"(Size) Aretino Apple Juice");
        }
    }
}
