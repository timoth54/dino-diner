﻿/*
 * PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified By: Timothy Tucker
 */

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        public override double Price { get; protected set; }
        public override uint Calories { get; protected set; }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }

        public void HoldJelly()
        {
            this.jelly = false;
        }

        /// <summary>
        /// String representation of PrehistoricPBJ object.
        /// </summary>
        /// <returns>Name of the entree.</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
