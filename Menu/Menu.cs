/*
 * Menu.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Specification for making a Menu
    /// </summary>
    public class Menu
    {
        private List<IMenuItem> availableMenuItems;
        private List<Entree> availableEntrees;
        private List<Side> availableSides;
        private List<Drink> availableDrinks;
        private List<CretaceousCombo> availableCombos;

        /// <summary>
        /// Gets the list of available menu items.
        /// </summary>
        public List<IMenuItem> AvailableMenuItems { get => availableMenuItems; }

        /// <summary>
        /// Gets the list of available entrees.
        /// </summary>
        public List<Entree> AvailableEntrees { get => availableEntrees; }

        /// <summary>
        /// Gets the list of available sides.
        /// </summary>
        public List<Side> AvailableSides { get => availableSides; }

        /// <summary>
        /// Gets the list of available drinks.
        /// </summary>
        public List<Drink> AvailableDrinks { get => availableDrinks; }

        /// <summary>
        /// Gets the list of available combos.
        /// </summary>
        public List<CretaceousCombo> AvailableCombos { get => availableCombos; }

        /// <summary>
        /// Gets the possible of possible ingredients.
        /// </summary>
        public HashSet<string> PossibleIngredients { get => GetPossibleIngredients(); }

        /// <summary>
        /// Creates a new instance of the Menu.
        /// </summary>
        public Menu()
        {
            availableMenuItems = new List<IMenuItem>();
            availableEntrees = new List<Entree>()
            {
                new Brontowurst(),
                new DinoNuggets(),
                new PrehistoricPBJ(),
                new PterodactylWings(),
                new SteakosaurusBurger(),
                new TRexKingBurger(),
                new VelociWrap()
            };

            availableSides = new List<Side>()
            {
                new Fryceritops(),
                new MeteorMacAndCheese(),
                new MezzorellaSticks(),
                new Triceritots()
            };

            availableDrinks = new List<Drink>()
            {
                new JurassicJava(),
                new Sodasaurus(),
                new Tyrannotea(),
                new Water()
            };

            availableCombos = new List<CretaceousCombo>();

            foreach (Entree entree in availableEntrees)
            {
                availableCombos.Add(new CretaceousCombo(entree));
            }

            //Add all existing entrees, sides, drinks, and combos to
            // the list of available menu items.
            availableMenuItems.AddRange(availableEntrees);
            availableMenuItems.AddRange(availableSides);
            availableMenuItems.AddRange(availableDrinks);
            availableMenuItems.AddRange(availableCombos);
        }

        /// <summary>
        /// String representation of Menu object.
        /// </summary>
        /// <returns>Names of all available menu items.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem menuItem in availableMenuItems)
            {
                string item = menuItem.ToString();
                
                //If the item begins with "Small" it is a
                // Sodasaurus or Side; so, replace default
                // parameters with empty strings.
                if (menuItem.ToString().StartsWith("Small"))
                {
                    item = item.Replace("Small ", "");
                    item = item.Replace("Cherry ", "");
                }

                sb.Append(item + "\n");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Gets all possible ingredients in the menu items.
        /// </summary>
        public HashSet<string> GetPossibleIngredients()
        {
            HashSet<string> possibleIngredients = new HashSet<string>();

            foreach (Entree entree in availableEntrees)
            {
                foreach (string ingredient in entree.Ingredients)
                {
                    possibleIngredients.Add(ingredient);
                }
            }

            foreach (Side side in availableSides)
            {
                foreach (string ingredient in side.Ingredients)
                {
                    possibleIngredients.Add(ingredient);
                }
            }

            foreach (Drink drink in availableDrinks)
            {
                foreach (string ingredient in drink.Ingredients)
                {
                    possibleIngredients.Add(ingredient);
                }
            }

            return possibleIngredients;
        }
    }
}
