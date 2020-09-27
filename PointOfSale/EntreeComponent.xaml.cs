/*
 * Author: Amy Neeland
 * Class: EntreeComponent.xaml.cs
 * Purpose: This class represents the entree Selections of Point Of Sale
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
    /// Interaction logic for EntreeComponent.xaml
    /// </summary>
    public partial class EntreeComponent : UserControl
    {
        EntreeOptions eo = new EntreeOptions();

        public EntreeComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for Briarheart Burger selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void BriarheartBurger(object sender, RoutedEventArgs e)
        {
            eo = new EntreeOptions();
            containerBorder.Child = eo;
            eo.entree.Text = "Briarheart Burger";
            burgerBase();
        }

        /// <summary>
        /// Event handler for Double Draugr selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void DoubleDraugr(object sender, RoutedEventArgs e)
        {
            eo = new EntreeOptions();
            containerBorder.Child = eo;
            eo.entree.Text = "Double Draugr";
            burgerBase();
            eo.lettuce.Visibility = Visibility.Visible;
            eo.lettuce.IsChecked = true;
            eo.tomato.Visibility = Visibility.Visible;
            eo.tomato.IsChecked = true;
            eo.mayo.Visibility = Visibility.Visible;
            eo.mayo.IsChecked = true;
        }

        /// <summary>
        /// Event handler for Thalmor Triple selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void ThalmorTriple(object sender, RoutedEventArgs e)
        {
            eo = new EntreeOptions();
            containerBorder.Child = eo;
            eo.entree.Text = "Thalmor Triple";
            burgerBase();
            eo.lettuce.Visibility = Visibility.Visible;
            eo.lettuce.IsChecked = true;
            eo.tomato.Visibility = Visibility.Visible;
            eo.tomato.IsChecked = true;
            eo.mayo.Visibility = Visibility.Visible;
            eo.mayo.IsChecked = true;
            eo.egg.Visibility = Visibility.Visible;
            eo.egg.IsChecked = true;
            eo.bacon.Visibility = Visibility.Visible;
            eo.bacon.IsChecked = true;
        }

        /// <summary>
        /// Event handler for Smokehouse Skeleton selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void SmokehouseSkeleton(object sender, RoutedEventArgs e)
        {
            eo = new EntreeOptions();
            containerBorder.Child = eo;
            eo.entree.Text = "Smokehouse Skeleton";
            eo.sausage.Visibility = Visibility.Visible;
            eo.sausage.IsChecked = true;
            eo.egg.Visibility = Visibility.Visible;
            eo.egg.IsChecked = true;
            eo.hashbrowns.Visibility = Visibility.Visible;
            eo.hashbrowns.IsChecked = true;
            eo.pancake.Visibility = Visibility.Visible;
            eo.pancake.IsChecked = true;
        }

        /// <summary>
        /// Event handler for Garden Orc Omelette selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void GardenOrcOmelette(object sender, RoutedEventArgs e)
        {
            eo = new EntreeOptions();
            containerBorder.Child = eo;
            eo.entree.Text = "Garden Orc Omelette";
            eo.broccoli.Visibility = Visibility.Visible;
            eo.broccoli.IsChecked = true;
            eo.mushrooms.Visibility = Visibility.Visible;
            eo.mushrooms.IsChecked = true;
            eo.tomato.Visibility = Visibility.Visible;
            eo.tomato.IsChecked = true;
            eo.cheddar.Visibility = Visibility.Visible;
            eo.cheddar.IsChecked = true;
        }

        /// <summary>
        /// Event handler for Philly Poacher selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void PhillyPoacher(object sender, RoutedEventArgs e)
        {
            eo = new EntreeOptions();
            containerBorder.Child = eo;
            eo.entree.Text = "Philly Poacher";
            eo.sirloin.Visibility = Visibility.Visible;
            eo.sirloin.IsChecked = true;
            eo.onion.Visibility = Visibility.Visible;
            eo.onion.IsChecked = true;
            eo.roll.Visibility = Visibility.Visible;
            eo.roll.IsChecked = true;
        }

        /// <summary>
        /// Event handler for Thugs T-Bone selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void ThugsTBone(object sender, RoutedEventArgs e)
        {
            eo = new EntreeOptions();
            containerBorder.Child = eo;
            eo.entree.Text = "Thugs T-Bone";
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
        /// Sets basic options for all burger menu items
        /// </summary>
        void burgerBase()
        {
            eo.bun.Visibility = Visibility.Visible;
            eo.bun.IsChecked = true;
            eo.ketchup.Visibility = Visibility.Visible;
            eo.ketchup.IsChecked = true;
            eo.mustard.Visibility = Visibility.Visible;
            eo.mustard.IsChecked = true;
            eo.pickle.Visibility = Visibility.Visible;
            eo.pickle.IsChecked = true;
            eo.cheese.Visibility = Visibility.Visible;
            eo.cheese.IsChecked = true;
        }

    }
}
