/*
 *Author: Amy Neeland
 * Class: MarkarthMilk.cs
 * Purpose: This class represents the Markarth Milk item
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// The Markarth milk item
    /// </summary>
    public class MarkarthMilk: Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// gets description of item
        /// </summary>
        public String Description => "Hormone-free organic 2% milk.";

        /// <summary>
        /// gets menu item type
        /// </summary>
        public String ItemType => "Drink";

        //private variables for properties
        private bool ice = false;
        private Size size = Size.Small;

        /// <value>
        /// gets and sets the size of the drink
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
        /// gets the items price depending on size
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.05;
                    case Size.Medium:
                        return 1.11;
                    case Size.Large:
                        return 1.22;
                    default:
                        throw new NotImplementedException($"Unknown size of (Size)");
                }
            }
        }

        /// <value>
        /// gets item calories depending on size
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 56;
                    case Size.Medium:
                        return 72;
                    case Size.Large:
                        return 93;
                    default:
                        throw new NotImplementedException($"Unknown size of (Size)");
                }
            }
        }


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
        ///  get list of special instructions
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return ($"{Size} Markarth Milk");
        }
    }
}
