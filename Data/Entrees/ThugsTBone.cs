/*
 * Author: Amy Neeland
 * Class: ThugsTBone.cs
 * Purpose: Class that represents the Thugs T-Bone item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Thugs TBone
    /// </summary>
    public class ThugsTBone: Entree, IOrderItem, INotifyPropertyChanged
    {
        
        /// <value>
        /// gets the items price
        /// </value>
        public override double Price => 6.44;

        /// <value>
        /// gets item calories
        /// </value>
        public override uint Calories => 982;

        /// <value>
        ///  get list of special instructions
        /// </value>
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
