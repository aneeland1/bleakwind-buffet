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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeComponent.xaml
    /// </summary>
    public partial class EntreeComponent : UserControl
    {
        EntreeOptions eo = new EntreeOptions();
        public OrderComponent OrderList { get; set; }

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
            //eo.entree.Text = "Briarheart Burger";
            BriarheartBurger bb = new BriarheartBurger();
            eo.entree.Text = bb.ToString();
            eo.DataContext = bb;
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
            //eo.entree.Text = "Double Draugr";
            DoubleDraugr dd = new DoubleDraugr();
            eo.entree.Text = dd.ToString();
            eo.DataContext = dd;
            burgerBase();
            eo.lettuce.Visibility = Visibility.Visible;
            //eo.lettuce.IsChecked = true;
            eo.tomato.Visibility = Visibility.Visible;
            //eo.tomato.IsChecked = true;
            eo.mayo.Visibility = Visibility.Visible;
            //eo.mayo.IsChecked = true;
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
            //eo.entree.Text = "Thalmor Triple";
            ThalmorTriple tt = new ThalmorTriple();
            eo.entree.Text = tt.ToString();
            eo.DataContext = tt;
            burgerBase();
            eo.lettuce.Visibility = Visibility.Visible;
            //eo.lettuce.IsChecked = true;
            eo.tomato.Visibility = Visibility.Visible;
            //eo.tomato.IsChecked = true;
            eo.mayo.Visibility = Visibility.Visible;
            //eo.mayo.IsChecked = true;
            eo.egg.Visibility = Visibility.Visible;
            //eo.egg.IsChecked = true;
            eo.bacon.Visibility = Visibility.Visible;
            //eo.bacon.IsChecked = true;
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
            //eo.entree.Text = "Smokehouse Skeleton";
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            eo.entree.Text = ss.ToString();
            eo.DataContext = ss;
            eo.sausage.Visibility = Visibility.Visible;
            //eo.sausage.IsChecked = true;
            eo.egg.Visibility = Visibility.Visible;
            //eo.egg.IsChecked = true;
            eo.hashbrowns.Visibility = Visibility.Visible;
            //eo.hashbrowns.IsChecked = true;
            eo.pancake.Visibility = Visibility.Visible;
            //eo.pancake.IsChecked = true;
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
            //eo.entree.Text = "Garden Orc Omelette";
            GardenOrcOmelette go = new GardenOrcOmelette();
            eo.entree.Text = go.ToString();
            eo.DataContext = go;
            eo.broccoli.Visibility = Visibility.Visible;
            //eo.broccoli.IsChecked = true;
            eo.mushrooms.Visibility = Visibility.Visible;
            //eo.mushrooms.IsChecked = true;
            eo.tomato.Visibility = Visibility.Visible;
            //.tomato.IsChecked = true;
            eo.cheddar.Visibility = Visibility.Visible;
            //eo.cheddar.IsChecked = true;
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
            //eo.entree.Text = "Philly Poacher";
            PhillyPoacher pp = new PhillyPoacher();
            eo.entree.Text = pp.ToString();
            eo.DataContext = pp;
            eo.sirloin.Visibility = Visibility.Visible;
            //eo.sirloin.IsChecked = true;
            eo.onion.Visibility = Visibility.Visible;
            //eo.onion.IsChecked = true;
            eo.roll.Visibility = Visibility.Visible;
            //eo.roll.IsChecked = true;
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
            ThugsTBone tb = new ThugsTBone();
            eo.entree.Text = tb.ToString();
            eo.DataContext = tb;
        }

        /// <summary>
        /// Event handler for home button selection
        /// </summary>
        /// <param name="sender">control exectuting event</param>
        /// <param name="e">data for event</param>
        void Home(object sender, RoutedEventArgs e)
        {
            //containerBorder.Child = new CategoryComponent();
            DependencyObject parent = this;
            do
            {
                parent = LogicalTreeHelper.GetParent(parent);
            } while (!(parent is MainWindow || parent is null));
            if (parent is MainWindow category)
            {
                containerBorder.Child = new CategoryComponent();
            }

        }

        /// <summary>
        /// Sets basic options for all burger menu items
        /// </summary>
        void burgerBase()
        {
            eo.bun.Visibility = Visibility.Visible;
            //eo.bun.IsChecked = true;
            eo.ketchup.Visibility = Visibility.Visible;
            //eo.ketchup.IsChecked = true;
            eo.mustard.Visibility = Visibility.Visible;
            //eo.mustard.IsChecked = true;
            eo.pickle.Visibility = Visibility.Visible;
            //eo.pickle.IsChecked = true;
            eo.cheese.Visibility = Visibility.Visible;
            //eo.cheese.IsChecked = true;
        }

        /// <summary>
        /// Action when Complete Order button is clicked
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
