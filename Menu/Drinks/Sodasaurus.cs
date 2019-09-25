using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus
    {
        private Size size;

        public SodasaurusFlavor Flavor;

        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value == Size.Small)
                {
                    Price = 1.50;
                    Calories = 112;
                    size = value;
                }
                else if (value == Size.Medium)
                {
                    Price = 2.00;
                    Calories = 156;
                    size = value;
                }
                else
                {
                    Price = 2.50;
                    Calories = 208;
                    size = value;
                }
            }
        }

        public double Price = 1.50;

        public uint Calories = 112;

        public bool Ice = true;

        public Sodasaurus()
        {
            this.size = Size.Small;
            this.Flavor = SodasaurusFlavor.Cherry;
        }
    }
}
