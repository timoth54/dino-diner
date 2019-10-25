/*
 * IOrderItem.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specifies all things an order
    /// item has.
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets the price of the order item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets the description of the order item.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the special preparations for the order item.
        /// </summary>
        string[] Special { get; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}
