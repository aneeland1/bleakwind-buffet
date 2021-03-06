﻿/*
 * Author: Amy Neeland
 * Class: DrinkComponent.xaml.cs
 * Purpose: This class represents the Drink selections of Point Of Sale
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkComponent.xaml
    /// </summary>
    public partial class DrinkComponent : UserControl
    {
        DrinkOptions drink;
        public OrderComponent OrderList { get; set; } //test for order component
        
        public DrinkComponent(OrderComponent order)
        {
            InitializeComponent();
            this.OrderList = order;            
        }

        /// <summary>
        /// Event handler for sailor soda selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void SailorSoda(object sender, RoutedEventArgs e)
        {
            drink = new DrinkOptions();
            containerBorder.Child = drink;
            SailorSoda ss = new SailorSoda();
            drink.OrderList = OrderList;
            drink.DataContext = ss;
            
            drink.drink.Text = "Sailor Soda";
            drink.ice.Visibility = Visibility.Visible;
            drink.sodaFlavors.Visibility = Visibility.Visible;
                      
        }

        /// <summary>
        /// Event handler for aretino apple juice selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void AretinoAppleJuice(object sender, RoutedEventArgs e)
        {
            drink = new DrinkOptions();
            containerBorder.Child = drink;
            AretinoAppleJuice aj = new AretinoAppleJuice();
            drink.OrderList = OrderList;
            drink.DataContext = aj;
            //drink.OrderList.DataContext = OrderList.DataContext;  //test data context for order component
            drink.drink.Text = "Aretino Apple Juice";
            drink.ice.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Event handler for markarth milk selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void MarkarthMilk(object sender, RoutedEventArgs e)
        {
            drink = new DrinkOptions();
            containerBorder.Child = drink;
            MarkarthMilk mm = new MarkarthMilk();
            drink.OrderList = OrderList;
            drink.DataContext = mm;
            drink.drink.Text = "Markarth Milk";
            drink.ice.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Event handler for Candlehearth Coffee selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void CandlehearthCoffee(object sender, RoutedEventArgs e)
        {
            drink = new DrinkOptions();
            containerBorder.Child = drink;
            CandlehearthCoffee cc = new CandlehearthCoffee();
            drink.DataContext = cc;
            drink.OrderList = OrderList;
            drink.drink.Text = "Candlehearth Coffee";
            drink.ice.Visibility = Visibility.Visible;
            drink.cream.Visibility = Visibility.Visible;
            drink.decaf.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Event handler for warrior water selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void WarriorWater(object sender, RoutedEventArgs e)
        {
            drink = new DrinkOptions();
            containerBorder.Child = drink;
            WarriorWater ww = new WarriorWater();
            drink.DataContext = ww;
            drink.drink.Text = "Warrior Water";
            drink.OrderList = OrderList;
            drink.ice.Visibility = Visibility.Visible;
            drink.ice.IsChecked = true;
            drink.lemon.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Event handler for home button
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void Home(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new CategoryComponent();
        }

        /// <summary>
        /// Action when complete order is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrder(object sender, RoutedEventArgs e)
        {
            PaymentOptions po = new PaymentOptions(OrderList);
            containerBorder.Child = po;
        }
    }
}
