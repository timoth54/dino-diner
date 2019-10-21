/*
 * OrderTest.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldGiveCorrectSubtotal()
        {
            Order order = new Order();
            order.Items.Add(new Brontowurst());
            order.Items.Add(new Fryceritops());
            order.Items.Add(new Sodasaurus());
            Assert.Equal<double>(7.85, order.SubtotalCost);
        }

        [Fact]
        public void ShouldGiveCorrectSalesCostForDefault()
        {
            Order order = new Order();
            order.Items.Add(new Brontowurst());
            order.Items.Add(new Fryceritops());
            order.Items.Add(new Sodasaurus());
            Assert.Equal<double>(0, order.SalesTaxCost);
        }
    }
}
