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

            ObservableCollection<IOrderItem> orderItems = new ObservableCollection<IOrderItem>();
            orderItems.Add(new Brontowurst());
            orderItems.Add(new Fryceritops());
            orderItems.Add(new Sodasaurus());

            order.Items = orderItems;
            Assert.Equal(7.85, order.SubtotalCost, 2);
            Assert.Equal(7.85, order.TotalCost, 2);
        }

        [Fact]
        public void ShouldGiveCorrectSalesTaxCostForDefaultTaxRate()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> orderItems = new ObservableCollection<IOrderItem>();
            orderItems.Add(new Brontowurst());
            orderItems.Add(new Fryceritops());
            orderItems.Add(new Sodasaurus());
            order.Items = orderItems;
            Assert.Equal<double>(0, order.SalesTaxCost);
        }

        [Fact]
        public void ShouldGiveNonNegativeSubtotalCostForLargeDiscount()
        {
            Order order = new Order();
            ObservableCollection<IOrderItem> orderItems = new ObservableCollection<IOrderItem>();
            Brontowurst brontowurst = new Brontowurst();
            brontowurst.Price = -99;
            orderItems.Add(brontowurst);
            orderItems.Add(new Fryceritops());
            orderItems.Add(new Sodasaurus());
            order.Items = orderItems;
            Assert.Equal<double>(0, order.SubtotalCost);
        }
    }
}
