/*
 * Author: Amy Neeland
 * Class: SideOptions.xaml.cs
 * Purpose: This class represents the side options of Point Of Sale
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideOptions.xaml
    /// </summary>
    public partial class SideOptions : UserControl
    {
        public OrderComponent OrderList { get; set; }

        public SideOptions()
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
        /// Event handler for done button
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void Back(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new SideComponent();
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
