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

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// A list of items being ordered.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// The cost of all items collectively.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                if (Items.Count != 0)
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
        /// The tax rate.
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// The amount paid in taxes for the order.
        /// </summary>
        public double SalesTaxCost { get => (SubtotalCost * SalesTaxRate); }

        /// <summary>
        /// Total price of the order.
        /// </summary>
        public double TotalCost { get => (SubtotalCost + SalesTaxCost); }

        /// <summary>
        /// Creates a new Order.
        /// </summary>
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
            SalesTaxRate = 5;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged();
            Items.Add(item);
        }
    }
}
