/*
 * Author: Amy Neeland
 * Class: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// gets the items price
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// gets item calories
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// get the value of sausage link and sets the default value to true
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// get the value of egg and sets the default value to true
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// get the value of hashbrowns and sets the default value to true
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// get the value of pancake and sets the default value to true
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        ///  get list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
