/*
 * Author: Amy Neeland
 * Class Name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for Briarheart Burger
    /// </summary>
    public class BriarheartBurger: Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //private variables for properties
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <value>
        /// gets item price
        /// </value>
        public override double Price => 6.32;

        /// <value>
        /// get item calories
        /// </value>
        public override uint Calories => 743;

        /// <value>
        /// get the value of ketchup, also sets the default value to true
        /// </value>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }

        /// <value>
        /// get the value of Bun, also sets the default value to true
        /// </value>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }
        
        /// <value>
        /// get the value of mustard, also sets the default value to true
        /// </value>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }

        /// <value>
        /// get the value of pickle, also sets the default value to true
        /// </value>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }

        /// <value>
        /// get the value of cheese, also sets the default value to true
        /// </value>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
