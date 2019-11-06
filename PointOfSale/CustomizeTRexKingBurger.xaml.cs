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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger trex;
        public CustomizeTRexKingBurger(TRexKingBurger trex)
        {
            InitializeComponent();
            this.trex = trex;
        }

        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            trex.HoldBun();
        }
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            trex.HoldKetchup();
        }
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            trex.HoldMustard();
        }
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            trex.HoldPickle();
        }
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            trex.HoldMayo();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            trex.HoldLettuce();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            trex.HoldOnion();
        }
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            trex.HoldTomato();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
