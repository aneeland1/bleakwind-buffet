/*
 * Author: Amy Neeland
 * Class: GardenOrcOmelette.cs
 * Purpose: Class that represents the Garden Orc Omelette item
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// gets the items price
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// gets item calories
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// get the value of broccoli and sets the default value to true
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// get the value of mushrooms and sets the default value to true
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// get the value of tomato and sets the default value to true
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// get the value of cheddar and sets the default value to true
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        ///  get list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
