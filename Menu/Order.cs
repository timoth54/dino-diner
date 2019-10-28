/*
 * Order.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making an order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {

        //Backing variables
        public List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// The PropertyChanged event handler, notifies when a property's value updates.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// A list of items being ordered.
        /// </summary>

        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }

        /// <summary>
        /// Gets the collective cost of all items
        /// before a tax is applied.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                if (Items.Length != 0)
                {
                    double subtotalCost = 0;
                    foreach (IOrderItem item in Items)
                    {
                        subtotalCost += item.Price;
                    }
                    return Math.Max(0, subtotalCost);
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets the tax rate.
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// Gets the amount paid in taxes for the order.
        /// </summary>
        public double SalesTaxCost { get => (SubtotalCost * SalesTaxRate); }

        /// <summary>
        /// Gets the total price of the order.
        /// </summary>
        public double TotalCost { get => (SubtotalCost + SalesTaxCost); }

        /// <summary>
        /// Creates a new Order.
        /// </summary>
        public Order()
        {
            SalesTaxRate = .05;
        }

        /// <summary>
        /// Notifies of a property change.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        protected void NotifyAllPropertiesChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        /// <summary>
        /// Adds a new item to the order.
        /// </summary>
        /// <param name="item">The item being added.</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertiesChanged();
        }

        /// <summary>
        /// Removes a item from the order.
        /// </summary>
        /// <param name="item">The item being removed.</param>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertiesChanged();
            }
            return removed;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertiesChanged();
        }
    }
}
