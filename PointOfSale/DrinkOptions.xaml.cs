﻿/*
 * Author: Amy Neeland
 * Class: DrinoOptions.xaml.cs
 * Purpose: This class represents the drink options of Point Of Sale
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkOptions.xaml
    /// </summary>
    public partial class DrinkOptions : UserControl
    {
        public DrinkOptions()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event handler for decrease quantity selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void Decrease(object sender, RoutedEventArgs e)
        {
            int qty = Convert.ToInt32(quantity.Text);
            if (qty == 0) return;
            else
            {
                qty--;
                quantity.Text = qty.ToString();
            }
        }

        /// <summary>
        /// Event handler for increase quantity selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void Increase(object sender, RoutedEventArgs e)
        {
            int qty = Convert.ToInt32(quantity.Text);
            qty++;
            quantity.Text = qty.ToString();
        }

        /// <summary>
        /// Event handler for home button selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void Home(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new CategoryComponent();
        }

        /// <summary>
        /// Event handler for Done button selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void Done(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new DrinkComponent();
        }
    }
}