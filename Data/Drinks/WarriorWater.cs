/*
 * Author: Amy Neeland
 * Class: WarriorWater.cs
 * Purpose: This class represents the Warrior Water item
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// The Warrior Water item
    /// </summary>
    public class WarriorWater: Drink, IOrderItem
    {
        
        /// <summary>
        /// gets item price
        /// </summary>
        public override double Price => 0;

        /// <summary>
        /// gets item calories
        /// </summary>
        public override uint Calories => 0;

        /// <summary>
        /// get the value of ice and sets the default value to true
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// get the value of lemon and sets the default value to false
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        ///  get list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return ($"{Size} Warrior Water");
        }

    }
}
