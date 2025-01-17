﻿using System;
using System.Collections.Generic;
/*
 * CustomizeVelociWrap.xaml.cs
 * Author:: Timothy Tucker
 */

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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        VelociWrap vw;
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }

        public void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            vw.HoldDressing();
        }

        public void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            vw.HoldLettuce();
        }

        public void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            vw.HoldCheese();
        }

        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
