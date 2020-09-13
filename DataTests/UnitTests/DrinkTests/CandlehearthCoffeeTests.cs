/*
 * Author: Zachery Brunner
 * Edited: Amy Neeland
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Runtime.CompilerServices;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    /// <summary>
    /// Runs tests on the CandlehearthCoffee.cs class
    /// </summary>
    public class CandlehearthCoffeeTests
    {
        /// <summary>
        /// Tests that item is a drink
        /// </summary>
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cc);
        }

        /// <summary>
        /// Tests that the default value of ice is false
        /// </summary>
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Ice);
        }

        /// <summary>
        /// Tests that the default value of decaf is false
        /// </summary>
        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.Decaf);
        }

        /// <summary>
        /// Tests that the default value for RoomForCream is false
        /// </summary>
        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.False(cc.RoomForCream);
        }

        /// <summary>
        /// Tests that the default size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cc.Size);
        }

        /// <summary>
        /// Tests that the size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = true;
            Assert.True(cc.Ice);
            cc.Ice = false;
            Assert.False(cc.Ice);
        }

        /// <summary>
        /// Tests that the value of Decaf can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = true;
            Assert.True(cc.Decaf);
            cc.Decaf = false;
            Assert.False(cc.Decaf);
        }

        /// <summary>
        /// Tests that the value of RoomForCream can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.RoomForCream = true;
            Assert.True(cc.RoomForCream);
            cc.RoomForCream = false;
            Assert.False(cc.RoomForCream);
        }

        /// <summary>
        /// Tests that the size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = Size.Large;
            Assert.Equal(Size.Large, cc.Size);
            cc.Size = Size.Medium;
            Assert.Equal(Size.Medium, cc.Size);
            cc.Size = Size.Small;
            Assert.Equal(Size.Small, cc.Size);
        }

        /// <summary>
        /// Tests that the price is correct for each size
        /// </summary>
        /// <param name="size">The size to test</param>
        /// <param name="price">The correct price</param>
        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        /// <summary>
        /// Tests that the calories are correct for each size
        /// </summary>
        /// <param name="size">The size to test</param>
        /// <param name="cal">The correct calories</param>
        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Size = size;
            Assert.Equal(cal, cc.Calories);
        }

        /// <summary>
        /// Tests that the Special Instructions are correct
        /// </summary>
        /// <param name="includeIce">The value of ice for special instructions</param>
        /// <param name="includeCream">The value of cream for special instructions</param>
        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Ice = includeIce;
            cc.RoomForCream = includeCream;
            if (includeIce && includeCream)
            {
                Assert.Contains("Add ice", cc.SpecialInstructions);
                Assert.Contains("Add cream", cc.SpecialInstructions);
            }
            else if (includeIce && !includeCream)
            {
                Assert.Contains("Add ice", cc.SpecialInstructions);
                Assert.DoesNotContain("Add cream", cc.SpecialInstructions);
            }
            else if (includeCream && !includeIce)
            {
                Assert.Contains("Add cream", cc.SpecialInstructions);
            }
            else Assert.Empty(cc.SpecialInstructions);
        }

        /// <summary>
        /// Tests that the name of the item is correct for each size
        /// </summary>
        /// <param name="decaf">The value of decaf</param>
        /// <param name="size">The size</param>
        /// <param name="name">The correct name</param>
        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            cc.Decaf = decaf;
            cc.Size = size;
            Assert.Equal(name, cc.ToString());
        }
    }
}
