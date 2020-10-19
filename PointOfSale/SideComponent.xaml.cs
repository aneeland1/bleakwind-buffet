/*//
 * Author: Amy Neeland
 * Class: SideComponent.xaml.cs
 * Purpose: This class represents the side Selections of Point Of Sale
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideComponent.xaml
    /// </summary>
    public partial class SideComponent : UserControl
    {
        SideOptions so = new SideOptions();
        public OrderComponent OrderList { get; set; } //test

        public SideComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Vokun Salad selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void VokunSalad(object sender, RoutedEventArgs e)
        {
            so = new SideOptions();
            containerBorder.Child = so;
            VokunSalad vs = new VokunSalad();            
            so.DataContext = vs;
            so.side.Text = "Vokun Salad";
        }

        /// <summary>
        /// Event handler for Fried Miraak selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void FriedMiraak(object sender, RoutedEventArgs e)
        {
            so = new SideOptions();
            containerBorder.Child = so;
            FriedMiraak fm = new FriedMiraak();            
            so.DataContext = fm;
            so.side.Text = "Fried Miraak";
        }

        /// <summary>
        /// Event handler for Mad Otar Grits selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void MadOtarGrits(object sender, RoutedEventArgs e)
        {
            so = new SideOptions();
            containerBorder.Child = so;
            MadOtarGrits mg = new MadOtarGrits();            
            so.DataContext = mg;
            so.side.Text = "Mad Otar Grits";
        }

        /// <summary>
        /// Event handler for Dragonborn Waffle Fries selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void DragonbornWaffleFries(object sender, RoutedEventArgs e)
        {
            so = new SideOptions();
            containerBorder.Child = so;
            DragonbornWaffleFries df = new DragonbornWaffleFries();            
            so.DataContext = df;
            so.side.Text = "Dragonborn Waffle Fries";
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
        /// todo
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
