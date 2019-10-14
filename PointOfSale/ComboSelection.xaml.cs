using System.Windows.Controls;
using System.Windows.Input;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void CustomizeCombo(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
