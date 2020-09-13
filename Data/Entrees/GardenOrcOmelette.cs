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
    /// <summary>
    /// Class for the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette: Entree, IOrderItem
    {
        /// <summary>
        /// gets the items price
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// gets item calories
        /// </summary>
        public override uint Calories => 404;

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
        public override List<string> SpecialInstructions
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
