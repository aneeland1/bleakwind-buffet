/*
 * Author: Zachery Brunner
 * Edited: Amy Neeland
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Runs tests on the PhillyPoacher.cs class
    /// </summary>
    public class PhillyPoacherTests
    {
        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = true;
            });

            Assert.PropertyChanged(pp, "Sirloin", () =>
            {
                pp.Sirloin = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = true;
            });

            Assert.PropertyChanged(pp, "Onion", () =>
            {
                pp.Onion = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = true;
            });

            Assert.PropertyChanged(pp, "Roll", () =>
            {
                pp.Roll = false;
            });
        }

        /// <summary>
        /// Tests that the item is an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(pp);
        }

        /// <summary>
        /// Tests that the item is a IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnOrderItem()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(pp);
        }

        /// <summary>
        /// Tests that the default value of sirloin is true
        /// </summary>
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// Tests that the default value of onion is true
        /// </summary>
        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// Tests that the value of roll is true
        /// </summary>
        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.True(pp.Roll);
        }

        /// <summary>
        /// Tests that value of sirloin can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = false;
            Assert.False(pp.Sirloin);
            pp.Sirloin = true;
            Assert.True(pp.Sirloin);
        }

        /// <summary>
        /// Tests that the value of onion can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Onion = false;
            Assert.False(pp.Onion);
            pp.Onion = true;
            Assert.True(pp.Onion);
        }

        /// <summary>
        /// Tests that the value of roll can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Roll = false;
            Assert.False(pp.Roll);
            pp.Roll = true;
            Assert.True(pp.Roll);
        }

        /// <summary>
        /// Tests that the price is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(7.23, pp.Price);
        }

        /// <summary>
        /// Tests that the calories are correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal(784, (double)pp.Calories);
        }

        /// <summary>
        /// Tests that the special instructions are correct
        /// </summary>
        /// <param name="includeSirloin">The value of sirloin to test</param>
        /// <param name="includeOnion">The value of onion to test</param>
        /// <param name="includeRoll">The value of roll to test</param>
        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher pp = new PhillyPoacher();
            pp.Sirloin = includeSirloin;
            pp.Onion = includeOnion;
            pp.Roll = includeRoll;
            
            if (!includeSirloin && !includeOnion && !includeRoll)
            { 
                Assert.Contains("Hold sirloin", pp.SpecialInstructions);
                Assert.Contains("Hold onions", pp.SpecialInstructions);
                Assert.Contains("Hold roll", pp.SpecialInstructions);
            }
            else Assert.Empty(pp.SpecialInstructions);
        }

        /// <summary>
        /// Tests that the name is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher pp = new PhillyPoacher();
            Assert.Equal("Philly Poacher", pp.ToString());
        }
    }
}