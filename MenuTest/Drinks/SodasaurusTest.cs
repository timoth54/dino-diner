/*
 * SodasaurusTest.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        [Theory]
        [InlineData(SodasaurusFlavor.Cola)]
        [InlineData(SodasaurusFlavor.Cherry)]
        [InlineData(SodasaurusFlavor.Orange)]
        [InlineData(SodasaurusFlavor.Vanilla)]
        [InlineData(SodasaurusFlavor.Chocolate)]
        [InlineData(SodasaurusFlavor.RootBeer)]
        [InlineData(SodasaurusFlavor.Lime)]
        //The ability to set each possible flavor.
        public void ShouldBeAbleToSetFlavor(SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = flavor;
            Assert.Equal<SodasaurusFlavor>(flavor, soda.Flavor);
        }

        //The correct default price, calories, ice, and size.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        //The correct price and calories after changing to small, medium, and large.
        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        //The correct ice after invoking HoldIce() method.
        [Fact]
        public void ShouldHaveCorrectIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = new List<string>();
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
            Assert.Equal<List<string>>(ingredients, soda.Ingredients);
        }

        [Theory]
        [InlineData(SodasaurusFlavor.Cola, Size.Small)]
        [InlineData(SodasaurusFlavor.Cherry, Size.Small)]
        [InlineData(SodasaurusFlavor.Orange, Size.Small)]
        [InlineData(SodasaurusFlavor.Vanilla, Size.Small)]
        [InlineData(SodasaurusFlavor.Chocolate, Size.Small)]
        [InlineData(SodasaurusFlavor.RootBeer, Size.Small)]
        [InlineData(SodasaurusFlavor.Lime, Size.Small)]
        [InlineData(SodasaurusFlavor.Cola, Size.Medium)]
        [InlineData(SodasaurusFlavor.Cherry, Size.Medium)]
        [InlineData(SodasaurusFlavor.Orange, Size.Medium)]
        [InlineData(SodasaurusFlavor.Vanilla, Size.Medium)]
        [InlineData(SodasaurusFlavor.Chocolate, Size.Medium)]
        [InlineData(SodasaurusFlavor.RootBeer, Size.Medium)]
        [InlineData(SodasaurusFlavor.Lime, Size.Medium)]
        [InlineData(SodasaurusFlavor.Cola, Size.Large)]
        [InlineData(SodasaurusFlavor.Cherry, Size.Large)]
        [InlineData(SodasaurusFlavor.Orange, Size.Large)]
        [InlineData(SodasaurusFlavor.Vanilla, Size.Large)]
        [InlineData(SodasaurusFlavor.Chocolate, Size.Large)]
        [InlineData(SodasaurusFlavor.RootBeer, Size.Large)]
        [InlineData(SodasaurusFlavor.Lime, Size.Large)]
        public void SodasaurusDescriptionShouldHaveItemName(SodasaurusFlavor flavor, Size size)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = flavor;
            soda.Size = size;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.Description);
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Contains("Hold Ice", soda.Special);
        }
    }
}
