/*
 * Author: Amy Neeland
 * Class: ThugsTBone.cs
 * Purpose: Class that represents the Thugs T-Bone item
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Thugs TBone
    /// </summary>
    public class ThugsTBone: Entree, IOrderItem
    {
        /// <summary>
        /// gets the items price
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// gets item calories
        /// </summary>
        public override uint Calories => 982;

        /// <summary>
        ///  get list of special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
