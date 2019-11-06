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
            smallButton.IsEnabled = true;
            smallButton.IsChecked = true;
            mediumButton.IsEnabled = true;
            largeButton.IsEnabled = true;
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
