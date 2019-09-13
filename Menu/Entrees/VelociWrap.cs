/*
 * VelociWrap.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    /// <summary>
    /// Specification of making a Veloci-Wrap
    /// </summary>
    class VelociWrap
    {
        /// <summary>
        /// Add dressing to the order.
        /// </summary>
        private bool Dressing = true;

        /// <summary>
        /// Add romaine lettuce to the order.
        /// </summary>
        private bool Lettuce = true;

        /// <summary>
        /// Add cheese to the order.
        /// </summary>
        private bool Cheese = true;

        /// <summary>
        /// The price of a Veloci-Wrap.
        /// </summary>
        public double Price
        {
            get;
            private set;
        }

        /// <summary>
        /// The Calories in a Veloci-Wrap.
        /// </summary>
        public uint Calories
        {
            get;
            private set;
        }

        /// <summary>
        /// Makes a new Veloci-Wrap.
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }
    }
}
