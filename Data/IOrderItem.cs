﻿/*
 * Author: Amy Neeland
 * Class: IOrderItem.cs
 * Purpose: Interface class for menu items
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        string Name { get; }

        string ItemType { get; }

        /// <summary>
        /// Price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions of the item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// gets description of item
        /// </summary>
        string Description { get; }

    }
}
