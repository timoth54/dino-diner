/*
 * MenuCategorySelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Creates a new page for selecting a combo, entree, side, or drink.
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Select a new combo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// Select a new entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// Select a new side.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }

        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
