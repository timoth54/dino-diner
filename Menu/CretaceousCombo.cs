/*
 * CretaceousCombo.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specifcation for making a Crestaceous Combo
    /// </summary>
    public class CretaceousCombo : IMenuItem, IOrderItem
    {
        //Private backing fields
        private Entree entree;
        private Drink drink;
        private Side side;
        private Size size = Size.Small;

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Gets or sets the entree.
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
             set
            {
                entree = value;
                entree.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Gets or sets the drink.
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                drink.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Gets or sets the side.
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                side.PropertyChanged += OnItemPropertyChanged;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
            }
        }

        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Drink.Price + Side.Price - .25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Entree.Calories + Side.Calories;
            }
        }

        /// <summary>
        /// Gets ingredients of combo.
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// Gets a description of the combo.
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// Gets a list of special preparations
        /// for the combo.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> specials = new List<string>();
                specials.AddRange(Entree.Special);
                specials.Add(Side.Description);
                specials.AddRange(Side.Special);
                specials.Add(Drink.Description);
                specials.AddRange(Drink.Special);
                return specials.ToArray();
            }
        }

        /// <summary>
        /// Makes a new Cretaceous Combo.
        /// </summary>
        /// <param name="entree">The entree in the combo.</param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            entree.PropertyChanged += OnItemPropertyChanged;
            side = new Fryceritops();
            drink = new Sodasaurus();
        }

        /// <summary>
        /// String representation of CretaceousCombo object.
        /// </summary>
        /// <returns>Name of the combo.</returns>
        public override string ToString()
        {
            return String.Format($"{Entree} Combo");
        }

        /// <summary>
        /// Notifies of when a property changes.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Notifies of all properties that change
        /// in an item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyOfPropertyChange("Size");
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Price");
            NotifyOfPropertyChange("Description");
            NotifyOfPropertyChange("Calories");
        }
    }
}
