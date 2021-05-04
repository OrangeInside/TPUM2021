﻿using System;
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

namespace GUI.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSetFrameWithClients(object sender, RoutedEventArgs e)
        {
            this.ClientsForm.Visibility = Visibility.Visible;
            this.VinylsForm.Visibility = Visibility.Hidden;
            this.OrdersForm.Visibility = Visibility.Hidden;
        }

        private void OnSetFrameWithVinyls(object sender, RoutedEventArgs e)
        {
            this.ClientsForm.Visibility = Visibility.Hidden;
            this.VinylsForm.Visibility = Visibility.Visible;
            this.OrdersForm.Visibility = Visibility.Hidden;
        }

        private void OnSetFrameWithOrders(object sender, RoutedEventArgs e)
        {
            this.ClientsForm.Visibility = Visibility.Hidden;
            this.VinylsForm.Visibility = Visibility.Hidden;
            this.OrdersForm.Visibility = Visibility.Visible;
        }
    }
}
