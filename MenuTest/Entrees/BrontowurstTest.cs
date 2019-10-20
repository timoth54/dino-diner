using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void BrontowurstDescriptionShouldGiveItemName()
        {
            Brontowurst brontowurst = new Brontowurst();
            Assert.Equal("Brontowurst", brontowurst.Description);
        }

        [Fact]
        public void SpecialShouldHoldBun()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldBun();
            Assert.Contains("Hold Bun", brontowurst.Special);
        }

        [Fact]
        public void SpecialShouldHoldPeppers()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldPeppers();
            Assert.Contains("Hold Peppers", brontowurst.Special);
        }

        [Fact]
        public void SpecialShouldHoldOnion()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldOnion();
            Assert.Contains("Hold Onion", brontowurst.Special);
        }

        [Fact]
        public void SpecialShouldHoldBunAndPeppers()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldBun();
            brontowurst.HoldPeppers();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                });
        }

        [Fact]
        public void SpecialShouldHoldBunAndOnion()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldBun();
            brontowurst.HoldOnion();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void SpecialShouldHoldPeppersAndOnion()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldPeppers();
            brontowurst.HoldOnion();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onion", item);
                });
        }

        [Fact]
        public void SpecialShouldHoldAll()
        {
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.HoldBun();
            brontowurst.HoldPeppers();
            brontowurst.HoldOnion();
            Assert.Collection<string>(brontowurst.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item => 
                {
                    Assert.Equal("Hold Onion", item);
                });
        }
    }

}
