/*
 * Author: Amy Neeland
 * Class: Side.cs
 * Purpose: Base class for side object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void InvokePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions of the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
