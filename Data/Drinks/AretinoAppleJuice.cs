/*
 *Author: Amy Neeland
 * Class: AretinoAppleJuice.cs
 * Purpose: This class represents the Aretino Apple Juice item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{

    /// <summary>
    /// Class representing the Arentino Apple Juice item
    /// </summary>
    public class AretinoAppleJuice: Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //private variables for properties
        private bool ice = false;
        private Size size = Size.Small;
        
        /// <value>
        /// Gets and sets the size of the drink
        /// </value>
        public override Size Size
        {
            get => size;
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
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
                        return .62;
                    case Size.Medium:
                        return .87;
                    case Size.Large:
                        return 1.01;
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
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        // <value>
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
            return ($"{Size} Aretino Apple Juice");
        }
    }
}
