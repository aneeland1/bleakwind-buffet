/*
 * Author: Amy Neeland
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class
 */

using Xunit;

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;


namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAnOrderItem()
        {
            Order o = new Order();
            Assert.IsAssignableFrom<IOrderItem>(o);
        }
    }
}
