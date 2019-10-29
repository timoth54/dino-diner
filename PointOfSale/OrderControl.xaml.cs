/*
 * OrderControl.xaml.cs
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Initializes the control.
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Removes item from order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Notifies of property changes to the collection.
        /// </summary>
        private void MountItemListener()
        {
            if (DataContext is Order order)
            {
                order.PropertyChanged += OnCollectionChanged;
            }
        }

        /// <summary>
        /// Updates that the collection has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnCollectionChanged(object sender, EventArgs args)
        {
            CollectionViewSource.GetDefaultView(OrderItems.Items).MoveCurrentToLast();
        }

        /// <summary>
        /// Updates when the selected item has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MountItemListener();
        }

        /// <summary>
        /// Updates that the DataContext has changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MountItemListener();
        }
    }
}
