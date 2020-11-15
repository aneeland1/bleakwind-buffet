/*
 * Author: Amy Neeland
 * Class: ThalmorTriple
 * Purpose: Class used to represent the Thalmor Triple item
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for the Thalmor Triple
    /// </summary>
    public class ThalmorTriple: Entree, IOrderItem, INotifyPropertyChanged
    {
        
        //private variables for properties
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

        /// <summary>
        /// gets description of item
        /// </summary>
        public String Description => "Think you are strong enough to take on the Thalmor?" +
            "Includes two 1/4lb patties with a 1/2lb patty in between with ketchup, mustard, " +
            "pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";

        /// <value>
        /// gets the items price
        /// </value>
        public override double Price => 8.32;

        /// <value>
        /// gets item calories
        /// </value>
        public override uint Calories => 943;

        /// <value>
        /// gets and sets the value of bun
        /// </value>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                InvokePropertyChanged("Bun");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get and sets the value of ketchup
        /// </value>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                InvokePropertyChanged("Ketchup");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// gets and sets value of mustard
        /// </value>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                InvokePropertyChanged("Mustard");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// gets and sets the value of pickle
        /// </value>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                InvokePropertyChanged("Pickle");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get and sets the value of cheese
        /// </value>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                InvokePropertyChanged("Cheese");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get and sets the value of tomato
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
        /// gets and sets the value of lettuce
        /// </value>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                InvokePropertyChanged("Lettuce");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// gets and sets value of mayo
        /// </value>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                InvokePropertyChanged("Mayo");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// gets and sets value of bacon
        /// </value>
        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                InvokePropertyChanged("Bacon");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// gets and sets value of egg
        /// </value>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                InvokePropertyChanged("Egg");
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
