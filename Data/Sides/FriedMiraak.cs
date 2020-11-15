/*
 * Author: Amy Neeland
 * Class: FriedMiraak.cs
 * Purpose: This class represents the Fried Miraak item
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak: Side, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// gets description of item
        /// </summary>
        public String Description => "Perfectly prepared hash brown pancakes.";

        //private variables for properties
        private Size size = Size.Small;

        /// <value>
        /// gets and sets the size of side
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
                        return 1.78;
                    case Size.Medium:
                        return 2.01;
                    case Size.Large:
                        return 2.88;
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
                        return 151;
                    case Size.Medium:
                        return 236;
                    case Size.Large:
                        return 306;
                    default:
                        throw new NotImplementedException($"Unknown size of (Size)");
                }
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
                return instructions;
            }
        }

        /// <value>
        /// Sets the to String to the item name
        /// </value>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return ($"{Size} Fried Miraak");
        }
    }
}
