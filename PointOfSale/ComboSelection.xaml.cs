using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {

        public CretaceousCombo Combo { get; protected set; }

        public ComboSelection()
        {
            InitializeComponent();
        }

        private void OnBrontowurstComboClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            
        }

        private void OnPterodactylWingsComboClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void OnDinoNuggetComboClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void OnPrehistoricPBJComboClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void OnSteakosaurusBurgerComboClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void OnTRexKingBurgerComboClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }

        private void OnVelociWrapComboClick(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
        }
    }
}
