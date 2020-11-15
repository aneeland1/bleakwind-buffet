/*
 * Author: Amy Neeland
 * Class: WarriorWater.cs
 * Purpose: This class represents the Warrior Water item
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// The Warrior Water item
    /// </summary>
    public class WarriorWater: Drink, IOrderItem, INotifyPropertyChanged
    {
        
        //private variables for properties
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;

        /// <summary>
        /// gets description of item
        /// </summary>
        public String Description => "It’s water. Just water.";

        /// <value>
        /// gets and sets the size of drink
        /// </value>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                InvokePropertyChanged("Size");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
            }
        }

        /// <value>
        /// gets item price
        /// </value>
        public override double Price => 0;

        /// <value>
        /// gets item calories
        /// </value>
        public override uint Calories => 0;

        /// <value>
        /// get the value of ice and sets the default value to true
        /// </value>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                InvokePropertyChanged("Ice");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get the value of lemon and sets the default value to false
        /// </value>
        public bool Lemon
        {
            get => lemon;
            set
            {
                lemon = value;
                InvokePropertyChanged("Lemon");
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
