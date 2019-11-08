/*
 * EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Reference to currently selected entree.
        /// </summary>
        public Entree Entree { get; private set; }

        /// <summary>
        /// Initializes the page for selecting an entree.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds entree to the order.
        /// </summary>
        /// <param name="entree">The entree being added.</param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
        }

        /// <summary>
        /// Adds Brontowurst to order,
        /// and navigates to the customization page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
            NavigationService.Navigate(new CustomizeBrontowurst(Entree as Brontowurst));
        }

        /// <summary>
        /// Adds Dino Nuggets to order,
        /// and navigates to the customization page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
            NavigationService.Navigate(new CustomizeDinoNuggets(Entree as DinoNuggets));
        }

        /// <summary>
        /// Adds Prehistoric PB&J to order,
        /// and navigates to the customization page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
            NavigationService.Navigate(new CustomizePrehistoricPBJ((PrehistoricPBJ)Entree));
        }

        /// <summary>
        /// Adds Pterodactyl Wings to order,
        /// and navigates to the customization page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        /// <summary>
        /// Adds Steakosaurus Burger to order,
        /// and navigates to the customization page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(Entree as SteakosaurusBurger));
        }

        /// <summary>
        /// Adds T-Rex King Burger to order,
        /// and navigates to the customization page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
            NavigationService.Navigate(new CustomizeTRexKingBurger(Entree as TRexKingBurger));
        }

        /// <summary>
        /// Adds veloci-wrap to order,
        /// and navigates to the customization page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
            NavigationService.Navigate(new CustomizeVelociWrap(Entree as VelociWrap));
        }
    }
}
