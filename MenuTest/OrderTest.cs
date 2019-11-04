/*
 * OrderTest.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.Collections.ObjectModel;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldGiveCorrectSubtotalAndTotal()
        {
            Order order = new Order();

            order.Add(new Brontowurst());
            order.Add(new Fryceritops());
            order.Add(new Sodasaurus());

            Assert.Equal(7.85, order.SubtotalCost, 2);
            Assert.Equal(7.85, order.TotalCost, 2);
        }

        [Fact]
        public void ShouldGiveCorrectSalesTaxCostForDefaultTaxRate()
        {
            Order order = new Order();
            order.Add(new Brontowurst());
            order.Add(new Fryceritops());
            order.Add(new Sodasaurus());
            Assert.Equal<double>(0, order.SalesTaxCost);
        }

        /*
        [Fact]
        public void ShouldGiveNonNegativeSubtotalCostForLargeDiscount()
        {
            Order order = new Order();
            Brontowurst brontowurst = new Brontowurst();
            order.Add(brontowurst);
            order.Add(new Fryceritops());
            order.Add(new Sodasaurus());
            Assert.Equal<double>(0, order.SubtotalCost);
        }*/
    }
}
