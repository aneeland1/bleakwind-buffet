/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Runs tests on the ThalmorTriple.cs class
    /// </summary>
    public class ThalmorTripleTests
    {
        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = true;
            });

            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = true;
            });

            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = true;
            });

            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = true;
            });

            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = true;
            });

            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = true;
            });

            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = true;
            });

            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = true;
            });

            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = true;
            });

            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = false;
            });
        }

        /// <summary>
        /// Checks whether property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = true;
            });

            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = false;
            });
        }

        /// <summary>
        /// Tests that item is an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        /// <summary>
        /// Tests that the item is a IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnOrderItem()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        /// <summary>
        /// Tests that the default value of bun is true
        /// </summary>
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Tests that the default value of ketchup is true
        /// </summary>
        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Tests that the default value of mustard is true
        /// </summary>
        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Tests that the default value of pickle is true
        /// </summary>
        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);    
        }

        /// <summary>
        /// Tests that the default value of cheese is true
        /// </summary>
        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Tests that the default value of tomato is true
        /// </summary>
        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Tests that the default value of lettuce is true
        /// </summary>
        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Tests that the default value of mayo is true
        /// </summary>
        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Tests that the default value of bacon is true
        /// </summary>
        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Tests that the default value of egg is true
        /// </summary>
        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Tests that the value of bun can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        /// <summary>
        /// Tests that the value of ketchup can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        /// <summary>
        /// Tests that the value of mustard can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        /// <summary>
        /// Tests that the value of pickle can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        /// <summary>
        /// Tests that the value of cheese can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        /// <summary>
        /// Tests that the value of tomato can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        /// <summary>
        /// Tests that the value of lettuce can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        /// <summary>
        /// Tests that the value of mayo can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        /// <summary>
        /// Tests that the value of bacon can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        /// <summary>
        /// Tests that the value of egg can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        /// <summary>
        /// Tests that the price is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        /// <summary>
        /// Tests that the calories are correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(943, (double)tt.Calories);
        }

        /// <summary>
        /// Tests that the special instructions are correct
        /// </summary>
        /// <param name="includeBun">The value of bun to test</param>
        /// <param name="includeKetchup">The value of ketchup to test</param>
        /// <param name="includeMustard">The value of mustard to test</param>
        /// <param name="includePickle">The value of pickle to test</param>
        /// <param name="includeCheese">The value of cheese to test</param>
        /// <param name="includeTomato">The value of tomato to test</param>
        /// <param name="includeLettuce">The value of lettuce to test</param>
        /// <param name="includeMayo">The value of mayo to test</param>
        /// <param name="includeBacon">The value of bacon to test</param>
        /// <param name="includeEgg">The value of egg to test</param>
        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            tt.Ketchup = includeKetchup;
            tt.Mustard = includeMustard;
            tt.Pickle = includePickle;
            tt.Cheese = includeCheese;
            tt.Tomato = includeTomato;
            tt.Lettuce = includeLettuce;
            tt.Mayo = includeMayo;
            tt.Bacon = includeBacon;
            tt.Egg = includeEgg;

            if (!includeBun && !includeKetchup && !includeMustard && !includePickle && !includeCheese && 
                !includeTomato && !includeLettuce && !includeMayo && !includeBacon && !includeEgg)
            {
                Assert.Contains("Hold bun", tt.SpecialInstructions);
                Assert.Contains("Hold ketchup", tt.SpecialInstructions);
                Assert.Contains("Hold mustard", tt.SpecialInstructions);
                Assert.Contains("Hold pickle", tt.SpecialInstructions);
                Assert.Contains("Hold cheese", tt.SpecialInstructions);
                Assert.Contains("Hold tomato", tt.SpecialInstructions);
                Assert.Contains("Hold lettuce", tt.SpecialInstructions);
                Assert.Contains("Hold mayo", tt.SpecialInstructions);
                Assert.Contains("Hold bacon", tt.SpecialInstructions);
                Assert.Contains("Hold egg", tt.SpecialInstructions);
            }
            else Assert.Empty(tt.SpecialInstructions);
        }

        /// <summary>
        /// Tests the name is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }
    }
}