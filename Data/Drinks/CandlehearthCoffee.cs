/*
 * Author: Amy Neeland
 * Class: CandlehearthCoffee.cs
 * Purpose: This class represents the Candlehearth Coffee item
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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
                        return .75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Large:
                        return 1.75;
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
                        return 7;
                    case Size.Medium:
                        return 10;
                    case Size.Large:
                        return 20;
                    default:
                        throw new NotImplementedException($"Unknown size of (Size)");
                }
            }
        }

        /// <summary>
        /// get the value of ice and sets the default value to false
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// get the value of room for cream and sets the default value to false
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// get the value of decaf and sets the default value to false
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        ///  get list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            if (Decaf) {

                return ($"{Size} Decaf Candlehearth Coffee");
            }
            else return($"{Size} Candlehearth Coffee");
        }
    }
}
