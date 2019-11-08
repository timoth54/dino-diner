/*
 * SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// Reference to the combo being modified.
        /// </summary>
        private CretaceousCombo Combo { get; set; }

        private Side side;

        /// <summary>
        /// Initializes the side selection page.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }

        //Constuctor that takes reference of a side.
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
        }

        /// <summary>
        /// Adds the selected side to the order.
        /// </summary>
        /// <param name="side">The side being added.</param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                if (Combo != null)
                {
                    Combo.Side = side;
                }
                else
                {
                    this.side = side;
                    order.Add(side);
                }
                smallButton.IsEnabled = true;
                mediumButton.IsEnabled = true;
                largeButton.IsEnabled = true;
            }
        }

        /// <summary>
        /// Selects size of side.
        /// </summary>
        /// <param name="size">The size of the side.</param>
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Combo != null)
            {
                Combo.Side.Size = size;
                NavigationService.Navigate(new ComboCustomization(Combo));
            }
            else
            {
                side.Size = size;
            }
        }

        /// <summary>
        /// EventHandler for adding Fryceritops
        /// to the order list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        /// <summary>
        /// EventHandler for adding Triceritots
        /// to the order list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        /// <summary>
        /// EventHandler for adding MozzerolaSticks
        /// to the order list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnMozzerellaSticks(object sender, RoutedEventArgs args)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// EventHandler for adding MeteorMacAndCheese
        /// to the order list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
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
