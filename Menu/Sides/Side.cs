﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    public abstract class Side : IMenuItem, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Gets a list of special preparations
        /// for the side.
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// Gets a description of the side.
        /// </summary>
        public virtual string Description { get => this.ToString(); }

    }
}
