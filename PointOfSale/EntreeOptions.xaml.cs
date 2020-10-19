/*
 * Author: Amy Neeland
 * Class: Entree Options.xaml.cs
 * Purpose: This class represents the entree options of Point Of Sale
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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeOptions.xaml
    /// </summary>
    public partial class EntreeOptions : UserControl
    {
        public OrderComponent OrderList { get; set; }

        public EntreeOptions()
        {
            InitializeComponent();
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
        /// Event handler for Done button
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void Back(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new EntreeComponent();
        }

        /// <summary>
        /// Todo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddToOrder(object sender, RoutedEventArgs e)
        {

            if (OrderList.DataContext is Order order)
            {
                order.Add((IOrderItem)this.DataContext);
            }
        }

    }
}
