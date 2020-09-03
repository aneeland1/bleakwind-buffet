﻿/*
 * Author: Amy Neeland
 * Class: ThalmorTriple
 * Purpose: Class used to represent the Thalmor Triple item
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// gets the items price
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// gets item calories
        /// </summary>
        public uint Calories => 943;

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
        /// get the value of tomato, also sets the default value to true
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// get value of lettuce and sets default value to true
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// get value of mayo and sets default to true
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// get value of bacon and sets default to true
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// get value of egg and sets default to true
        /// </summary>
        public bool Egg { get; set; } = true;

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
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}