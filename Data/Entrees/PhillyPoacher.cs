/*
 * Author: Amy Neeland
 * Class: PhillyPoacher.cs
 * Purpose: Class that represents the Philly Poacher item
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// gets the items price
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// gets item calories
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// get the value of sirloin and sets the default value to true
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// get value of onion and sets the default value to true
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// get value of roll and sets the default value to true
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        ///  get list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }

}
