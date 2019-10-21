/*
 * Drink.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstraction of all drinks.
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        protected Size size = Size.Small;

        /// <summary>
        /// Gets and sets the size of a drink.
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Gets the price of a drink.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets the calories in a drink.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets ingredients in a drink.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets a list of special preparations
        /// for the drink.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Gets a description of the drink.
        /// </summary>
        public virtual string Description { get => this.ToString(); }

        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public abstract event PropertyChangedEventHandler PropertyChanged;
    }
}
