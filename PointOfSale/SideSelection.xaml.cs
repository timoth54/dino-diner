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
        public Side Side { get; private set; }
        public SideSelection()
        {
            InitializeComponent();
        }

        public void AddFryceritops(object sender, RoutedEventArgs args)
        {
            Order order = new Order();
            order.Items.Add(new Fryceritops());
            FryceritopsButton.IsEnabled = false;
            MozzerellaSticksButton.IsEnabled = false;
            MeteorMacAndCheeseButton.IsEnabled = false;
            TriceritosButton.IsEnabled = false;
            smallButton.IsEnabled = true;
            mediumButton.IsEnabled = true;
            largeButton.IsEnabled = true;
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                this.Side = side;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
            {
                this.Side.Size = size;
            }
        }
        protected void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            SelectSide(new Fryceritops());
        }

        protected void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            SelectSide(new Triceritots());
        }

        protected void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            SelectSide(new MeteorMacAndCheese());
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
    }
}
