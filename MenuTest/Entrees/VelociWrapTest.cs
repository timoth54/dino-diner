using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void VelociWrapDescriptionShouldGiveItemName()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        [Fact]
        public void SpecialShouldHoldDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.Contains("Hold Dressing", vw.Special);
        }

        [Fact]
        public void SpecialShouldHoldLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.Contains("Hold Lettuce", vw.Special);
        }

        [Fact]
        public void SpecialShouldHoldCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.Contains("Hold Cheese", vw.Special);
        }

        [Fact]
        public void SpecialShouldHoldDressingAndLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            string[] special = vw.Special;
            Assert.Contains("Hold Dressing", special);
            Assert.Contains("Hold Lettuce", special);
        }
        [Fact]
        public void SpecialShouldHoldDressingAndCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldCheese();
            string[] special = vw.Special;
            Assert.Contains("Hold Dressing", special);
            Assert.Contains("Hold Cheese", special);
        }

        [Fact]
        public void SpecialShouldHoldLettuceAndCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            vw.HoldCheese();
            string[] special = vw.Special;
            Assert.Contains("Hold Lettuce", special);
            Assert.Contains("Hold Cheese", special);
        }

        [Fact]
        public void SpecialShouldHoldAll()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            vw.HoldLettuce();
            vw.HoldCheese();
            string[] special = vw.Special;
            Assert.Contains("Hold Dressing", special);
            Assert.Contains("Hold Lettuce", special);
            Assert.Contains("Hold Cheese", special);
        }
    }
}
