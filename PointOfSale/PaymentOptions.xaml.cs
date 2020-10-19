/*
 * Author: Amy Neeland
 * Class: PaymentOptions.xaml.cs
 * Purpose: This class represents the payment options of Point Of Sale
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
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        public OrderComponent OrderList { get; set; }

        /// <summary>
        /// constructor for payment options screen
        /// </summary>
        /// <param name="order"></param>
        public PaymentOptions(OrderComponent order) 
        {
            InitializeComponent();
            OrderList = order;
            var register = new RegisterViewModel();
            DataContext = register;
        }

        /// <summary>
        /// action when return to order button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ReturnToOrder(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new CategoryComponent();
        }

        /// <summary>
        /// action when credit/debit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCreditCard(object sender, RoutedEventArgs e)
        {
            if (DataContext is RegisterViewModel rg)
            {
                if(OrderList.DataContext is Order ord)
                {
                    RegisterViewModel.CardTransactionResult result = rg.RunCard(ord.Total);
                    if (result == RegisterViewModel.CardTransactionResult.Approved)
                    {
                        PrintOrder(rg, ord);
                        rg.PrintLine("Credit/Debit");
                        rg.PrintLine("Change Due: $ 0.00");
                        rg.CutTape();
                    }
                }
            }
        }

        /// <summary>
        /// Action when cash button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCash(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = new CashTransaction();
        }

        /// <summary>
        /// Action when Print Order button is clicked
        /// </summary>
        /// <param name="rm"></param>
        /// <param name="o"></param>
        void PrintOrder(RegisterViewModel rm, Order o)
        {
            rm.PrintLine("Bleakwind Buffet");
            rm.PrintLine($"Order Number: {o.Number}");
            foreach (IOrderItem orderItem in o)
            {
                rm.PrintLine($"{orderItem.Name}  {orderItem.Price}");
                o.SpecialInstructions.ForEach(rm.PrintLine);
            }
            rm.PrintLine($"Subtotal: ${o.Subtotal}");
            rm.PrintLine($"Tax: ${o.Tax}");
            rm.PrintLine($"Total: ${o.Total}");
        }
    }
}
