/*
 * Author: Amy Neeland
 * Class: Entree.cs
 * Purpose: Base class for entree object
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees
    /// </summary>
    public abstract class Entree : INotifyPropertyChanged
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
        /// The price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public abstract uint Calories { get;  }

        /// <summary>
        /// The special instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
