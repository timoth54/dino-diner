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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public Entree Entree { get; private set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }

        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        protected void OnSelectBrontowurst(object sender, RoutedEventArgs args)
        {
            SelectEntree(new Brontowurst());
            NavigationService.Navigate(new CustomizeBrontowurst(Entree as Brontowurst));
        }

        protected void OnSelectDinoNuggets(object sender, RoutedEventArgs args)
        {
            SelectEntree(new DinoNuggets());
            NavigationService.Navigate(new CustomizeDinoNuggets(Entree as DinoNuggets));
        }

        protected void OnSelectPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PrehistoricPBJ());
            NavigationService.Navigate(new CustomizePrehistoricPBJ((PrehistoricPBJ)Entree));
        }

        protected void OnSelectPterodactylWings(object sender, RoutedEventArgs args)
        {
            SelectEntree(new PterodactylWings());
        }

        protected void OnSelectSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new SteakosaurusBurger());
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(Entree as SteakosaurusBurger));
        }

        protected void OnSelectTRexKingBurger(object sender, RoutedEventArgs args)
        {
            SelectEntree(new TRexKingBurger());
            NavigationService.Navigate(new CustomizeTRexKingBurger(Entree as TRexKingBurger));
        }

        protected void OnSelectVelociWrap(object sender, RoutedEventArgs args)
        {
            SelectEntree(new VelociWrap());
        }
    }
}
