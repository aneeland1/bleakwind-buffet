/*
 * Author: Zachery Brunner
 * Edited: Amy Neeland
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Runtime.Serialization;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// Runs tests on the DragonbornWaffleFries.cs class
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        /// <summary>
        /// Tests that item is a side
        /// </summary>
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(df);
        }

        /// <summary>
        /// Tests that the default size is small
        /// </summary>
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, df.Size);
        }

        /// <summary>
        /// Tests that the size can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = Size.Large;
            Assert.Equal(Size.Large, df.Size);
            df.Size = Size.Medium;
            Assert.Equal(Size.Medium, df.Size);
            df.Size = Size.Small;
            Assert.Equal(Size.Small, df.Size);
        }

        /// <summary>
        /// Tests that the special instructions are correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            Assert.Empty(df.SpecialInstructions);
        }

        /// <summary>
        /// Tests that the price is correct for each size
        /// </summary>
        /// <param name="size">The size to test</param>
        /// <param name="price">The correct price</param>
        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = size;
            Assert.Equal(price, df.Price);

        }

        /// <summary>
        /// Tests that the calories are correct for each size
        /// </summary>
        /// <param name="size">The size to test</param>
        /// <param name="calories">The correct calories</param>
        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = size;
            Assert.Equal(calories, df.Calories);
        }

        /// <summary>
        /// Tests that the name is correct
        /// </summary>
        /// <param name="size"></param>
        /// <param name="name"></param>
        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries df = new DragonbornWaffleFries();
            df.Size = size;
            Assert.Equal(name, df.ToString());
        }
    }
}