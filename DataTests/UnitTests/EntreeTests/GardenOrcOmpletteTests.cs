/*
 * Author: Zachery Brunner
 * Edited: Amy Neeland
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// Runs tests on the GardenOrcOmelette.cs class
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        /// <summary>
        /// Tests that the item is an entree
        /// </summary>
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        /// <summary>
        /// Tests that the item is a IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnOrderItem()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
        }

        /// <summary>
        /// Tests that the default value of broccoli is true
        /// </summary>
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        /// <summary>
        /// Tests that the default value of mushrooms is correct
        /// </summary>
        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        /// <summary>
        /// Tests that the default value of tomato is true
        /// </summary>
        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        /// <summary>
        /// Tests that the default value of cheddar is true
        /// </summary>
        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// Tests that the value of broccoli can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        /// <summary>
        /// Tests that the value of mushrooms can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        /// <summary>
        /// Tests that the value of tomato can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        /// <summary>
        /// Tests that the value of cheddar can be set
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        /// <summary>
        /// Tests that the price is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        /// <summary>
        /// Tests that the calories are correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(404, (double)goo.Calories);
        }

        /// <summary>
        /// Tests that the Special Instructions are correct
        /// </summary>
        /// <param name="includeBroccoli">The value of broccoli to test</param>
        /// <param name="includeMushrooms">The value of mushrooms to test</param>
        /// <param name="includeTomato">The value of tomato to test</param>
        /// <param name="includeCheddar">The value of cheddar to test</param>
        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            goo.Mushrooms = includeMushrooms;
            goo.Tomato = includeTomato;
            goo.Cheddar = includeCheddar;
            
            if (!includeBroccoli && !includeMushrooms && !includeTomato && !includeCheddar)
            {
                Assert.Contains("Hold broccoli", goo.SpecialInstructions);
                Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
                Assert.Contains("Hold tomato", goo.SpecialInstructions);
                Assert.Contains("Hold cheddar", goo.SpecialInstructions);
            }
            else Assert.Empty(goo.SpecialInstructions);
        }
    
        /// <summary>
        /// Tests that the name is correct
        /// </summary>
        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }
    }
}