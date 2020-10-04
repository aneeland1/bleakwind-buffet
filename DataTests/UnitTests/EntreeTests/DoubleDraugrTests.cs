/*
 * Author: Zachery Brunner
 * Edited: Amy Neeland
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Runs tests on the DoubleDraugr.cs class
    /// </summary>
    public class DoubleDraugrTests
    {
        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = true;
            });

            Assert.PropertyChanged(dd, "Bun", () =>
            {
                dd.Bun = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = true;
            });

            Assert.PropertyChanged(dd, "Ketchup", () =>
            {
                dd.Ketchup = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = true;
            });

            Assert.PropertyChanged(dd, "Mustard", () =>
            {
                dd.Mustard = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = true;
            });

            Assert.PropertyChanged(dd, "Pickle", () =>
            {
                dd.Pickle = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = true;
            });

            Assert.PropertyChanged(dd, "Cheese", () =>
            {
                dd.Cheese = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = true;
            });

            Assert.PropertyChanged(dd, "Tomato", () =>
            {
                dd.Tomato = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = true;
            });

            Assert.PropertyChanged(dd, "Lettuce", () =>
            {
                dd.Lettuce = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = true;
            });

            Assert.PropertyChanged(dd, "Mayo", () =>
            {
                dd.Mayo = false;
            });
        }

        /// <summary>
        /// Tests that the item is an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(dd);
        }

        /// <summary>
        /// Tests that the item is a IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnOrderItem()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(dd);
        }

        /// <summary>
        /// Tests that the default value of bun is true
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Tests that the default value of ketchup is true
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Tests that the default value of mustard is true
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests that the default value of pickle is true
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests that the default value of cheese is true
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Tests that the default value of tomato is true
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Tests that the default value of lettuce is true
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Tests that the default value of mayo is true
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// Tests that the bun value can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = false;
            Assert.False(dd.Bun);
            dd.Bun = true;
            Assert.True(dd.Bun);
        }

        /// <summary>
        /// Tests that the ketchup value van be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Ketchup = false;
            Assert.False(dd.Ketchup);
            dd.Ketchup = true;
            Assert.True(dd.Ketchup);
        }

        /// <summary>
        /// Tests that the mustard value can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mustard = false;
            Assert.False(dd.Mustard);
            dd.Mustard = true;
            Assert.True(dd.Mustard);
        }

        /// <summary>
        /// Tests that the pickle value can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Pickle = false;
            Assert.False(dd.Pickle);
            dd.Pickle = true;
            Assert.True(dd.Pickle);
        }

        /// <summary>
        /// Tests that the value of cheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Cheese = false;
            Assert.False(dd.Cheese);
            dd.Cheese = true;
            Assert.True(dd.Cheese);
        }

        /// <summary>
        /// Tests that the value of tomato can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Tomato = false;
            Assert.False(dd.Tomato);
            dd.Tomato = true;
            Assert.True(dd.Tomato);
        }

        /// <summary>
        /// Tests that the value of lettuce can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Lettuce = false;
            Assert.False(dd.Lettuce);
            dd.Lettuce = true;
            Assert.True(dd.Lettuce);
        }

        /// <summary>
        /// Tests that the value of mayo can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Mayo = false;
            Assert.False(dd.Mayo);
            dd.Mayo = true;
            Assert.True(dd.Mayo);
        }

        /// <summary>
        /// Tests that the price is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(7.32, dd.Price);
        }

        /// <summary>
        /// Tests that the calories are correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal(843, (double)dd.Calories);
        }

        /// <summary>
        /// Tests that the special instructions are correct
        /// </summary>
        /// <param name="includeBun">The value of bun to test</param>
        /// <param name="includeKetchup">The value of bun to test</param>
        /// <param name="includeMustard">The value of ketchup to test</param>
        /// <param name="includePickle">The value of pickle to test</param>
        /// <param name="includeCheese">The value of cheese to test</param>
        /// <param name="includeTomato">The value of tomato to test</param>
        /// <param name="includeLettuce">The value of lettuce to test</param>
        /// <param name="includeMayo">The value of mayo to test</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr dd = new DoubleDraugr();
            dd.Bun = includeBun;
            dd.Ketchup = includeKetchup;
            dd.Mustard = includeMustard;
            dd.Pickle = includePickle;
            dd.Cheese = includeCheese;
            dd.Tomato = includeTomato;
            dd.Lettuce = includeLettuce;
            dd.Mayo = includeMayo;

            if (!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese && !includeTomato 
                && !includeLettuce && !includeMayo)
            {
                Assert.Contains("Hold bun", dd.SpecialInstructions);
                Assert.Contains("Hold ketchup", dd.SpecialInstructions);
                Assert.Contains("Hold mustard", dd.SpecialInstructions);
                Assert.Contains("Hold pickle", dd.SpecialInstructions);
                Assert.Contains("Hold tomato", dd.SpecialInstructions);
                Assert.Contains("Hold lettuce", dd.SpecialInstructions);
                Assert.Contains("Hold mayo", dd.SpecialInstructions);
            }
            else Assert.Empty(dd.SpecialInstructions);
        }

        /// <summary>
        /// Tests that the name is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr dd = new DoubleDraugr();
            Assert.Equal("Double Draugr", dd.ToString());
        }
    }
}