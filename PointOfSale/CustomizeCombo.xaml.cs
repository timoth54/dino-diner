/*
 * CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {

        CretaceousCombo Combo { get; set; }

        /// <summary>
        /// Creates a new page for combo customization.
        /// </summary>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
        }
    }
}
