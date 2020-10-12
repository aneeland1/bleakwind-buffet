using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data
{
    public class Order : IOrderItem, ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// constructor for order object
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
            
        }

        /// <summary>
        /// collection of order items
        /// </summary>
        List<IOrderItem> orderItems = new List<IOrderItem>();

        
        private static int nextOrderNumber = 1;

        /// <summary>
        /// private variable for sales tax
        /// </summary>
        private double salesTaxRate = 0.12;

        /// <summary>
        /// gets the number of the order
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// property to get and set the sales tax 
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
                InvokePropertyChanged("SalesTaxRate");
                InvokePropertyChanged("Tax");
                InvokePropertyChanged("Total");
                InvokePropertyChanged("Calories");
            }
        }

        /// <summary>
        /// property to get the order subtotal
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0.0;
                foreach (IOrderItem item in orderItems)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// property to get the order tax
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }

        /// <summary>
        /// property to get the order total
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;

            }
        }

        /// <summary>
        /// property to get the total calories for the order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach (IOrderItem item in orderItems)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// price
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// list of special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                foreach (IOrderItem item in orderItems)
                {
                    instructions.Add(item.ToString());
                    instructions.Add(item.SpecialInstructions.ToString());
                }
                return instructions;
            }
        }

        /// <summary>
        /// adds an item to a collection
        /// </summary>
        /// <param name="item">item to add</param>
        public void Add(IOrderItem item)
        {
            orderItems.Add(item);
            InvokePropertyChanged("SalesTaxRate");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");
            InvokePropertyChanged("SpecialInstructions");
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
        }

        /// <summary>
        /// removes an item from a collection
        /// </summary>
        /// <param name="item">item to remove</param>
        /// <returns>whether the item was removed</returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = orderItems.Remove(item);
            InvokePropertyChanged("SalesTaxRate");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
            return removed;
        }

        /// <summary>
        /// resets a collection
        /// </summary>
        public void Clear()
        {
            orderItems.Clear();
            InvokePropertyChanged("SalesTaxRate");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");
        }

        /// <summary>
        /// checks if an element is in a collection
        /// </summary>
        /// <param name="item">item to check</param>
        /// <returns>whether item is in the collection</returns>
        public bool Contains(IOrderItem item)
        {
            return orderItems.Contains(item);
        }

        /// <summary>
        /// copies a collection to an array
        /// </summary>
        /// <param name="item">item to copy</param>
        /// <param name="index">location in array</param>
        public void CopyTo(IOrderItem[] item, int index)
        {
            orderItems.CopyTo(item, index);
        }

        /// <summary>
        /// returns an enumerator that iterates through the collection
        /// </summary>
        /// <returns>enumerator that iterates through the collection</returns>
        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return orderItems.GetEnumerator();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return orderItems.GetEnumerator();
        }

        /// <summary>
        /// gets the count of items 
        /// </summary>
        public int Count
        {
            get
            {
                return orderItems.Count;
            }
        }

        /// <summary>
        /// gets whether the collection is read only
        /// /// </summary>
        public bool IsReadOnly { get; }

        /// <summary>
        /// Event handler for property change event
        /// </summary>
        /// <param name="property">name of property</param>
        public void InvokePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// event listener when a collection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            InvokePropertyChanged("Count");    
            
        }

        public void ItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            InvokePropertyChanged("Subtotal");
            InvokePropertyChanged("Tax");
            InvokePropertyChanged("Total");
            InvokePropertyChanged("Calories");                  
            
        }

    }
}
