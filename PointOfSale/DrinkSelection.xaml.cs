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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
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
        }

        /// <summary>
        /// Display options available to Jurassic Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JurassicJavaOptions(object sender, RoutedEventArgs e)
        {
            CaffeineButton.Visibility = Visibility.Visible;
            LemonButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Hidden;
            SweetenerButton.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Display options available to Water.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterOptions(object sender, RoutedEventArgs e)
        {
            CaffeineButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            FlavorButton.Visibility = Visibility.Hidden;
            SweetenerButton.Visibility = Visibility.Hidden;
        }

        private void ChangeFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
