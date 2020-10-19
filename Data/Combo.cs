/*
 * Author: Amy Neeland
 * Class: Combo.cs
 * Purpose: Class to represent a combo object
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public Combo()
        {
            drink.PropertyChanged += PropertyChangedListener;
            entree.PropertyChanged += PropertyChangedListener;
            side.PropertyChanged += PropertyChangedListener;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// private variables for properties
        /// </summary>
        private Entree entree = new BriarheartBurger();
        private Side side = new DragonbornWaffleFries();
        private Drink drink = new AretinoAppleJuice();
        
        public string Name { get; set; }

        /// <summary>
        /// property to get and set the entree of the combo
        /// </summary>
        public Entree Entree
        {
            get => entree;

            set
            {
                entree.PropertyChanged -= PropertyChangedListener;
                entree = value;
                entree.PropertyChanged += PropertyChangedListener;
                InvokePropertyChanged("Entree");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// property to get and set the side of the combo
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                side.PropertyChanged -= PropertyChangedListener;   
                side = value;
                side.PropertyChanged += PropertyChangedListener;
                InvokePropertyChanged("Side");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// property to get and set the drink of the combo
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                drink.PropertyChanged -= PropertyChangedListener;
                drink = value;
                drink.PropertyChanged += PropertyChangedListener;
                InvokePropertyChanged("Drink");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("Calories");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        ///  property to get the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 1.00;
            }
        }

        /// <summary>
        /// property to get the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// property to get the special instructions of the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(Entree.ToString());
                instructions.Add($"  {Entree.SpecialInstructions.ToString()}");
                instructions.Add(Side.ToString());
                instructions.Add(Drink.ToString());
                instructions.Add($"  {Drink.SpecialInstructions.ToString()}");
                return instructions;
            }
        }

        /// <summary>
        /// Event handler for property change event
        /// </summary>
        /// <param name="property">name of property</param>
        public void InvokePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// event listener for price and calories properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price") InvokePropertyChanged("Price");
            if (e.PropertyName == "Calories") InvokePropertyChanged("Calories");
            if (e.PropertyName == "SpecialInstructions") InvokePropertyChanged("SpecialInstructions");
        }
    }
}
