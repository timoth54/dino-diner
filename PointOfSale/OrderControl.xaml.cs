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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Items.Remove(item);
                    }
                }
            }
        }

        

        private void MountItemListener()
        {
            if (DataContext is Order order)
            {
                order.Items.CollectionChanged += OnCollectionChanged;
            }
        }

        public void OnCollectionChanged(object sender, EventArgs args)
        {
            CollectionViewSource.GetDefaultView(OrderItems.Items).MoveCurrentToLast();
        }

        public void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MountItemListener();
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MountItemListener();
        }
    }
}
