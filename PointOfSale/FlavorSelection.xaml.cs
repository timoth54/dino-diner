/*
 * FlavorSelection.xaml.cs
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// A reference to the sodasaurus being modified.
        /// </summary>
        public Sodasaurus Sodasaurus { get; private set; }

        /// <summary>
        /// Reference to the combo, who's drink is being customized.
        /// </summary>
        public CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Initializes the flavor selection page.
        /// </summary>
        /// <param name="sodasaurus">The sodasaurus being customized.</param>
        public FlavorSelection(Sodasaurus sodasaurus)
        {
            InitializeComponent();
            Sodasaurus = sodasaurus;
        }

        /// <summary>
        /// Intializes the flavor selection page
        /// to customize the a combo's drink.
        /// </summary>
        /// <param name="combo">The combo being customized.</param>
        public FlavorSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
            Sodasaurus = (Sodasaurus)combo.Drink;
        }

        /// <summary>
        /// Change Sodasaurus flavor to cherry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectCherry(object sender, RoutedEventArgs args)
        {
            Sodasaurus.Flavor = SodasaurusFlavor.Cherry;
        }

        /// <summary>
        /// Change Sodasaurus flavor to chocolate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectChocolate(object sender, RoutedEventArgs args)
        {
            Sodasaurus.Flavor = SodasaurusFlavor.Chocolate;
        }

        /// <summary>
        /// Change Sodasaurus flavor to vanilla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectVanilla(object sender, RoutedEventArgs args)
        {
            Sodasaurus.Flavor = SodasaurusFlavor.Vanilla;
        }

        /// <summary>
        /// Change Sodasaurus flavor to lime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectLime(object sender, RoutedEventArgs args)
        {
            Sodasaurus.Flavor = SodasaurusFlavor.Lime;
        }

        /// <summary>
        /// Change Sodasaurus flavor to cola.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectCola(object sender, RoutedEventArgs args)
        {
            Sodasaurus.Flavor = SodasaurusFlavor.Cola;
        }

        /// <summary>
        /// Change Sodasaurus flavor to orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectOrange(object sender, RoutedEventArgs args)
        {
            Sodasaurus.Flavor = SodasaurusFlavor.Orange;
        }

        /// <summary>
        /// Change Sodasaurus flavor to root beer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectRootBeer(object sender, RoutedEventArgs args)
        {
            Sodasaurus.Flavor = SodasaurusFlavor.RootBeer;
        }

        /// <summary>
        /// Navigates to the previous page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (Combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(Combo));
            }
            else
            {
                NavigationService.GoBack();
            }
        }
    }
}
