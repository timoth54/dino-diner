﻿/*
 * JurassicJava.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making a Jurassic Java.
    /// </summary>
    public class JurassicJava : Drink, INotifyPropertyChanged
    {
        private bool spaceForCream = false;
        private bool decaf = false;
        private bool ice = false;

        /// <summary>
        /// Gets if the drink has ice or not.
        /// </summary>
        public bool Ice { get => ice; }


        /// <summary>
        /// Gets or sets if the drink should have room for cream.
        /// </summary>
        public bool SpaceForCream
        {
            get
            {
                return spaceForCream;
            }
        }

        /// <summary>
        /// Gets or sets if the drink should be decaf.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Gets and sets size of drink.
        /// </summary>
        public override Size Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value == Size.Small)
                {
                    this.Price = .59;
                    this.Calories = 2;
                    this.size = value;
                }
                else if (value == Size.Medium)
                {
                    this.Price = .99;
                    this.Calories = 4;
                    this.size = value;
                }
                else
                {
                    this.Price = 1.49;
                    this.Calories = 8;
                    this.size = value;
                }

                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
            }

        }

        /// <summary>
        /// Gets ingredients in the drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }

        /// <summary>
        /// Gets a list of special preparations
        /// for the drink.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (ice) special.Add("Add Ice");
                if (spaceForCream) special.Add("Leave Space For Cream");
                return special.ToArray();
            }
        }

        /// <summary>
        /// The PropertyChanged event handler; notifies
        /// of changes to the Price, Description, and
        /// Special properties
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        //Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Makes a new Jurrasic Java.
        /// </summary>
        public JurassicJava()
        {
            this.ice = false;
            this.Price = .59;
            this.Calories = 2;
        }

        /// <summary>
        /// Leave room for cream on the drink.
        /// </summary>
        public void LeaveRoomForCream()
        {
            spaceForCream = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// Add ice to the drink.
        /// </summary>
        public void AddIce()
        {
            this.ice = true;
            NotifyOfPropertyChange("Special");
        }

        /// <summary>
        /// String representation of JurassicJava object.
        /// </summary>
        /// <returns>Name of the drink.</returns>
        public override string ToString()
        {
            if (!decaf)
            {
                return (size + " Jurassic Java");
            }
            else
            {
                return (size + " Decaf Jurassic Java");
            }
        }
    }
}
