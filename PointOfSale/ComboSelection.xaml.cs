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

        /// <summary>
        /// Adds the selected combo to the order.
        /// </summary>
        /// <param name="side">The side being added.</param>
        private void SelectCombo(CretaceousCombo combo)
        {
            if (DataContext is Order order)
            {
                    order.Add(combo);
                    this.Combo = combo ;
            }
        }

        private void OnBrontowurstComboClick(object sender, RoutedEventArgs args)
        {
            SelectCombo(new CretaceousCombo(new Brontowurst()));
            NavigationService.Navigate(new CustomizeCombo(Combo));
        }

        private void OnPterodactylWingsComboClick(object sender, RoutedEventArgs args)
        {
            new CustomizeCombo(new CretaceousCombo(new PterodactylWings()));
        }

        private void OnDinoNuggetComboClick(object sender, RoutedEventArgs args)
        {
            new CustomizeCombo(new CretaceousCombo(new DinoNuggets()));
        }

        private void OnPrehistoricPBJComboClick(object sender, RoutedEventArgs args)
        {
            new CustomizeCombo(new CretaceousCombo(new PrehistoricPBJ()));
        }

        private void OnSteakosaurusBurgerComboClick(object sender, RoutedEventArgs args)
        {
            new CustomizeCombo(new CretaceousCombo(new SteakosaurusBurger()));
        }

        private void OnTRexKingBurgerComboClick(object sender, RoutedEventArgs args)
        {
            new CustomizeCombo(new CretaceousCombo(new TRexKingBurger()));
        }

        private void OnVelociWrapComboClick(object sender, RoutedEventArgs args)
        {
            new CustomizeCombo(new CretaceousCombo(new VelociWrap()));
        }
    }
}
