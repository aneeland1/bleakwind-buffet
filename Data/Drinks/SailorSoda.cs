/*
 * Author: Amy Neeland
 * Class: SailorSoda.cs
 * Purpose: This class represents the Sailor Soda item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// The Sailor Soda item
    /// </summary>
    public class SailorSoda: Drink, IOrderItem, INotifyPropertyChanged
    {
        
        //private variables for properties
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// gets description of item
        /// </summary>
        public String Description => "An old-fashioned jerked soda, " +
            "carbonated water and flavored syrup poured over a bed of crushed ice.";

        /// <summary>
        /// gets menu item type
        /// </summary>
        public String ItemType => "Drink";

        /// <summary>
        /// property for size of drink
        /// </summary>
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
                switch(Size)
                {
                    case Size.Small:
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    case Size.Large:
                        return 2.07;
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
                switch(Size)
                {
                    case Size.Small:
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Large:
                        return 205;
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
        /// get the value of soda flavor and sets the default value to cherry
        /// </value>
        public SodaFlavor Flavor
        {
            get => flavor;
            set
            {
                flavor = value;
                InvokePropertyChanged("Flavor");
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
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return ($"{Size} {Flavor} Sailor Soda");
        }

    }
}
