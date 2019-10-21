/*
 * ComboTest.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class ComboTest
    {
        [Fact]
        public void ShouldGiveCorrectSpecial()
        {
            DinoNuggets dn = new DinoNuggets();
            Fryceritops ft = new Fryceritops();
            Sodasaurus soda = new Sodasaurus();
            dn.AddNugget();
            soda.HoldIce();
            ft.Size = Size.Large;

            CretaceousCombo combo = new CretaceousCombo(dn);
            combo.Side = ft;
            combo.Drink = soda;

            Assert.Collection<string>(combo.Special,
                item =>
                {
                    Assert.Equal("1 Extra Nuggets", item);
                },
                item =>
                {
                    Assert.Equal("Large Fryceritops", item);
                },
                item =>
                {
                    Assert.Equal("Small Cherry Sodasaurus", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void ShouldGiveCorrectDescription()
        {
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            Assert.Equal("Brontowurst Combo", combo.Description);
        }
    }
}
