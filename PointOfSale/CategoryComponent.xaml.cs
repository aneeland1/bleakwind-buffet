/*
 * Author: Amy Neeland
 * Class: CategoryComponent.xaml.cs
 * Purpose: This class represents the Category Selections of Point Of Sale
 */

using BleakwindBuffet.Data;
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
    /// Interaction logic for CategoryComponent.xaml
    /// </summary>
    public partial class CategoryComponent : UserControl
    {
        
        public CategoryComponent()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Event handler for entree selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void EntreeSelection(object sender, RoutedEventArgs e)
        {
            EntreeComponent ec = new EntreeComponent();
            containerBorder.Child = ec;
        }

        /// <summary>
        /// Event handler for side selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void SideSelection(object sender, RoutedEventArgs e)
        {
            SideComponent sc = new SideComponent();
            containerBorder.Child = sc;
        }

        /// <summary>
        /// Event handler for drink selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void DrinkSelection(object sender, RoutedEventArgs e)
        {
            DrinkComponent dc = new DrinkComponent();
            containerBorder.Child = dc;
        }
    }
}
