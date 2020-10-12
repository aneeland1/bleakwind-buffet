/*
 * Author: Amy Neeland
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the data library
 */

using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    /// <summary>
    /// runs test on the Combo.cs class
    /// </summary>
    public class ComboTests
    {
        /// <summary>
        /// checks whether entree property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingEntreeNotifiesEntreeProperty()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new DoubleDraugr();
            });

            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new ThalmorTriple();
            });

            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new GardenOrcOmelette();
            });

            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new SmokehouseSkeleton();
            });

            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new PhillyPoacher();
            });

            Assert.PropertyChanged(c, "Entree", () =>
            {
                c.Entree = new ThugsTBone();
            });
        }

        /// <summary>
        /// checks whether side property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingSideNotifiesSideProperty()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = new DragonbornWaffleFries();
            });

            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = new FriedMiraak();
            });

            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = new MadOtarGrits();
            });

            Assert.PropertyChanged(c, "Side", () =>
            {
                c.Side = new VokunSalad();
            });
        }

        /// <summary>
        /// checks whether side property is notified of a change
        /// </summary>
        [Fact]
        public void ChangingDrinkNotifiesDrinkProperty()
        {
            Combo c = new Combo();
            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new AretinoAppleJuice();
            });

            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new CandlehearthCoffee();
            });

            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new MarkarthMilk();
            });

            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new SailorSoda();
            });

            Assert.PropertyChanged(c, "Drink", () =>
            {
                c.Drink = new WarriorWater();
            });

        }

        /// <summary>
        /// Tests that the item is a IOrderItem
        /// </summary>
        [Fact]
        public void ShouldBeAnOrderItem()
        {
            Combo c = new Combo();
            Assert.IsAssignableFrom<IOrderItem>(c);
        }



        


    }
}
