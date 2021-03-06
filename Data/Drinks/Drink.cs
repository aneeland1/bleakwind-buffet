﻿/*
 * Author: Amy Neeland
 * Class: Drink.cs
 * Purpose: Base class for drink object
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged
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
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get;  set; }

        /// <summary>
        /// The price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

       
    }
}
