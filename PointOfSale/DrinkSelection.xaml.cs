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

        public Drink Drink { get; private set; }

        public DrinkSelection()
        {
            InitializeComponent();
        }

        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
                this.Drink = drink;
                smallButton.IsEnabled = true;
                mediumButton.IsEnabled = true;
                largeButton.IsEnabled = true;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Drink != null)
            {
                this.Drink.Size = size;
            }
        }

        protected void OnMakeLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }

        protected void OnMakeMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }

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

        private void OnRemoveCaffeine(object sender, RoutedEventArgs args)
        {
            JurassicJava java = (JurassicJava)Drink;
            java.Decaf = true;
        }

        private void OnLeaveSpaceForCream(object sender, RoutedEventArgs args)
        {
            JurassicJava java = (JurassicJava)Drink;
            java.LeaveSpaceForCream();
        }

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
            else
            {
                Sodasaurus soda = (Sodasaurus)Drink;
                soda.HoldIce();
            }
        }

        private void OnAddSweetener(object sender, RoutedEventArgs args)
        {
            Tyrannotea tea = (Tyrannotea)Drink;
            tea.Sweet = true;
        }

        private void OnChangeFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection((Sodasaurus)Drink));
        }
    }
}
