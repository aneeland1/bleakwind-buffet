/*
 * Author: Amy Neeland
 * Class: OrderComponent.xaml.cs
 * Purpose: This class represents the order recap of Point Of Sale
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        Order OrderList = new Order();

        /// <summary>
        /// constructor for order component
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            DataContext = OrderList;
            
        }

        /// <summary>
        /// Action when cancel order button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrder(object sender, RoutedEventArgs e)
        {
            OrderList = new Order();
            
        }
                      
    }
}
