/*
 * Author: Amy Neeland
 * Class: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class for the Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton: Entree, IOrderItem, INotifyPropertyChanged
    {
        
        //private variables for properties
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

        /// <summary>
        /// gets description of item
        /// </summary>
        public String Description => "Put some meat on those bones with a small stack of pancakes. " +
            "Includes sausage links, eggs, and hash browns on the side. " +
            "Topped with the syrup of your choice.";

        /// <value>
        /// gets the items price
        /// </value>
        public override double Price => 5.62;

        /// <value>
        /// gets item calories
        /// </value>
        public override uint Calories => 602;

        /// <value>
        /// get and set the value of sausage link
        /// </value>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                InvokePropertyChanged("SausageLink");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get and set the value of egg
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
        /// get and set the value of hashbrowns
        /// </value>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                InvokePropertyChanged("HashBrowns");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <value>
        /// get and set the value of pancake
        /// </value>
        public bool Pancake
        {
            get => pancake;
            set
            {
                pancake = value;
                InvokePropertyChanged("Pancake");
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
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Sets the to String to the item name
        /// </summary>
        /// <returns>name of item</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
