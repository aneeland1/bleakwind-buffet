﻿/*
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
        public event PropertyChangedEventHandler PropertyChanged;

        //private variables for properties
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
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
