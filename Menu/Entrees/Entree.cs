/*
 * Entree.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstraction of all entrees.
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public abstract double Price { get; protected set; }

        /// <summary>
        /// Gets and sets the calories.
        /// </summary>
        public abstract uint Calories { get; protected set; }

        /// <summary>
        /// Gets the ingredients list.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets a list of special preparations
        /// for the entree.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Gets a description of the entree.
        /// </summary>
        public virtual string Description { get => this.ToString(); }

        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
