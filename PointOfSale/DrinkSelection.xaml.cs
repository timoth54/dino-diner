/*
 * DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {

        /// <summary>
        /// Reference to combo.
        /// </summary>
        public CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Reference to currently selected drink.
        /// </summary>
        public Drink Drink { get; set; }

        /// <summary>
        /// Initializes drink selection page.
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes drink selection page
        /// for customizing combo's drink.
        /// </summary>
        /// <param name="combo">Combo being customized.</param>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
        }

        /// <summary>
        /// Selects drink.
        /// </summary>
        /// <param name="drink">Drink selected.</param>
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                if (Combo != null)
                {
                    Combo.Drink = drink;
                    Drink = drink;
                }
                else
                {
                    order.Add(drink);
                    Drink = drink;
                }
                smallButton.IsEnabled = true;
                smallButton.IsChecked = true;
                mediumButton.IsEnabled = true;
                largeButton.IsEnabled = true;
            }
        }

        /// <summary>
        /// Changes size of drink.
        /// </summary>
        /// <param name="size">Size selected.</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Combo != null)
            {
                Combo.Drink.Size = size;
            }
            else
            {
                Drink.Size = size;
            }
        }

        /// <summary>
        /// Makes drink large-sized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Makes drink medium-sized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

        /// <summary>
        /// Makes drink small-sized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMakeSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }


        /// <summary>
        /// Displays options available to Sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodasaurusOptions(object sender, RoutedEventArgs e)
        {
            LemonButton.Visibility = Visibility.Hidden;
            CaffeineButton.Visibility = Visibility.Hidden;
            SweetenerButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Visible;
            CreamButton.Visibility = Visibility.Hidden;
            IceButton.Visibility = Visibility.Visible;
            SelectDrink(new Sodasaurus());
        }

        /// <summary>
        /// Display options available to Tyranno Tea.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TyrannoteaOptions(object sender, RoutedEventArgs e)
        {
            LemonButton.Visibility = Visibility.Visible;
            SweetenerButton.Visibility = Visibility.Visible;
            CaffeineButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Hidden;
            CreamButton.Visibility = Visibility.Hidden;
            IceButton.Visibility = Visibility.Visible;
            SelectDrink(new Tyrannotea());
        }

        /// <summary>
        /// Display options available to Jurassic Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JurassicJavaOptions(object sender, RoutedEventArgs e)
        {
            CaffeineButton.Visibility = Visibility.Visible;
            CreamButton.Visibility = Visibility.Visible;
            LemonButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Hidden;
            SweetenerButton.Visibility = Visibility.Hidden;
            IceButton.Visibility = Visibility.Visible;
            SelectDrink(new JurassicJava());
        }

        /// <summary>
        /// Display options available to Water.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterOptions(object sender, RoutedEventArgs e)
        {
            CaffeineButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Visible;
            FlavorButton.Visibility = Visibility.Hidden;
            SweetenerButton.Visibility = Visibility.Hidden;
            CreamButton.Visibility = Visibility.Hidden;
            IceButton.Visibility = Visibility.Visible;
            SelectDrink(new Water());
        }

        /// <summary>
        /// Action for decaf button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveCaffeine(object sender, RoutedEventArgs args)
        {
            JurassicJava java = (JurassicJava)Drink;
            java.Decaf = true;
        }

        /// <summary>
        /// Action for cream button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnLeaveSpaceForCream(object sender, RoutedEventArgs args)
        {
            JurassicJava java = (JurassicJava)Drink;
            java.LeaveRoomForCream();
        }

        /// <summary>
        /// Action for lemon button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddLemon(object sender, RoutedEventArgs args)
        {
            if (Drink is Water water)
            {
                water.AddLemon();
            }
            else
            {
                Tyrannotea tea = (Tyrannotea)Drink;
                tea.AddLemon();
            }
        }

        /// <summary>
        /// Action for ice button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnIce(object sender, RoutedEventArgs args)
        {
            if (Drink is Water water)
            {
                water.HoldIce();
            }
            else if (Drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
            else if (Drink is JurassicJava java)
            {
                java.AddIce();
            }
            else if (Drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }
        }

        /// <summary>
        /// Action for sweetner button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnAddSweetener(object sender, RoutedEventArgs args)
        {
            Tyrannotea tea = (Tyrannotea)Drink;
            tea.Sweet = true;
        }

        /// <summary>
        /// Action for change flavor button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChangeFlavor(object sender, RoutedEventArgs e)
        {
            if (Combo != null)
            {
                NavigationService.Navigate(new FlavorSelection(Combo));
            }
            NavigationService.Navigate(new FlavorSelection((Sodasaurus)Drink));
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
