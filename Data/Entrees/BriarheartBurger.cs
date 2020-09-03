/*
 * Author: Amy Neeland
 * Class Name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger item
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger
    {
        /// <summary>
        /// gets item price
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// get item calories
        /// </summary>
        public uint Calories => 743;

        /// <summary>
        /// get the value of ketchup, also sets the default value to true
        /// </summary>
        public bool Bun { get; set; } = true; //can be used for all properties if using Special instructions as written

        /// <summary>
        /// get the value of Bun, also sets the default value to true
        /// </summary>
        public bool Ketchup { get; set; } = true;
        
        /// <summary>
        /// get the value of mustard, also sets the default value to true
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// get the value of pickle, also sets the default value to true
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// get the value of cheese, also sets the default value to true
        /// </summary>
        public bool Cheese { get; set; } = true;
        
        /// <summary>
        ///  get list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
