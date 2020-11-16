/*
 * Author: Amy Neeland
 * Class: PhillyPoacher.cs
 * Purpose: Class that represents the Philly Poacher item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for the Philly Poacher
    /// </summary>
    public class PhillyPoacher: Entree, IOrderItem, INotifyPropertyChanged
    {
        //private variables for properties
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// gets description of item
        /// </summary>
        public String Description => "Cheesesteak sandwich made from grilled sirloin, " +
            "topped with onions on a fried roll.";

        /// <summary>
        /// gets menu item type
        /// </summary>
        public String ItemType => "Entree";

        /// <value>
        /// gets the items price
        /// </value>
        public override double Price => 7.23;

        /// <value>
        /// gets item calories
        /// </value>
        public override uint Calories => 784;

        /// <value>
        /// get the value of sirloin and sets the default value to true
        /// </value>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                InvokePropertyChanged("Sirloin");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get value of onion and sets the default value to true
        /// </value>
        public bool Onion
        {
            get => onion;
            set
            {
                onion = value;
                InvokePropertyChanged("Onion");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get value of roll and sets the default value to true
        /// </value>
        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                InvokePropertyChanged("Roll");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        ///  get list of special instructions
        /// </value>
        public override List<string> SpecialInstructions
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
