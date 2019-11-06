/*
 * CustomizeCombo.xaml.cs
 * Author: Timothy Tucker
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;

        /// <summary>
        /// Creates a new page for combo customization.
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            smallButton.IsChecked = true;
        }

        /// <summary>
        /// Opens appropriate page for customizing
        /// entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCustomizeEntree(object sender, RoutedEventArgs args)
        {
            if (combo.Entree is Brontowurst brontowurst)
            {
                NavigationService.Navigate(new CustomizeBrontowurst(brontowurst));
            }
            else if (combo.Entree is DinoNuggets dn)
            {
                NavigationService.Navigate(new CustomizeDinoNuggets(dn));
            }
            else if (combo.Entree is PrehistoricPBJ prehistoricPBJ)
            {
                NavigationService.Navigate(new CustomizePrehistoricPBJ(prehistoricPBJ));
            }
            else if (combo.Entree is SteakosaurusBurger sb)
            {
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb));
            }
            else if (combo.Entree is TRexKingBurger rex)
            {
                NavigationService.Navigate(new CustomizeTRexKingBurger(rex));
            }
            else if (combo.Entree is VelociWrap vw)
            {
                NavigationService.Navigate(new CustomizeVelociWrap(vw));
            }
        }

        /// <summary>
        /// Selects size of combo.
        /// </summary>
        /// <param name="size">The size of the side.</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (combo != null)
            {
                this.combo.Size = size;
            }
        }

        /// <summary>
        /// EventHandler for changing size to large.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// EventHandler for changing size to medium.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// EventHandler for changing size to small.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
