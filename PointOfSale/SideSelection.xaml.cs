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
    }
}
