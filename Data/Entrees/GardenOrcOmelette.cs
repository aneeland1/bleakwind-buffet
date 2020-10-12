/*
 * Author: Amy Neeland
 * Class: GardenOrcOmelette.cs
 * Purpose: Class that represents the Garden Orc Omelette item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette: Entree, IOrderItem, INotifyPropertyChanged
    {
        //private variables for properties
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <value>
        /// gets the items price
        /// </value>
        public override double Price => 4.57;

        /// <value>
        /// gets item calories
        /// </value>
        public override uint Calories => 404;

        /// <value>
        /// get the value of broccoli and sets the default value to true
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                broccoli = value;
                InvokePropertyChanged("Broccoli");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get the value of mushrooms and sets the default value to true
        /// </value>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                mushrooms = value;
                InvokePropertyChanged("Mushrooms");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get the value of tomato and sets the default value to true
        /// </value>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                InvokePropertyChanged("Tomato");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get the value of cheddar and sets the default value to true
        /// </value>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                cheddar = value;
                InvokePropertyChanged("Cheddar");
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
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
