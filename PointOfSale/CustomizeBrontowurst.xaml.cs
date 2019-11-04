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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst brontowurst;
        //NavigationService NavigationService;

        public CustomizeBrontowurst(Brontowurst brontowurst)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            brontowurst.HoldBun();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldOnion();
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            brontowurst.HoldPeppers();
        }
    }
}
