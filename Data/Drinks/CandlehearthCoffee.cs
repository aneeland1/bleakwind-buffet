/*
 * Author: Amy Neeland
 * Class: CandlehearthCoffee.cs
 * Purpose: This class represents the Candlehearth Coffee item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class represents the Candlehearth Coffee item
    /// </summary>
    public class CandlehearthCoffee: Drink, IOrderItem, INotifyPropertyChanged
    {
        
        //private variables for properties
        private bool ice = false;
        private bool decaf;
        private bool roomForCream = false;
        private Size size = Size.Small;

        /// <value>
        /// Gets and sets the Size of the drink
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
                        return .75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Large:
                        return 1.75;
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
                        return 7;
                    case Size.Medium:
                        return 10;
                    case Size.Large:
                        return 20;
                    default:
                        throw new NotImplementedException($"Unknown size of (Size)");
                }
            }
        }
                 
        /// <value>
        /// get the value of ice and sets the default value to false
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
        /// get the value of room for cream and sets the default value to false
        /// </value>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                InvokePropertyChanged("roomForCream");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get the value of decaf and sets the default value to false
        /// </value>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                InvokePropertyChanged("decaf");
                
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
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            if (Decaf) {

                return ($"{Size} Decaf Candlehearth Coffee");
            }
            else return($"{Size} Candlehearth Coffee");
        }
    }
}
