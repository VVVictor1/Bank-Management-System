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
using System.Windows.Shapes;
using System.Data;
using DAL;

namespace BankCA2
{
    /// <summary>
    /// Interaction logic for Transaction.xaml
    /// </summary>
    public partial class Transaction : Window
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void dgvdata_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            DisplayData display = new DisplayData();
            DataTable userdata = display.TransactionAll();

            dgvdata.ItemsSource = userdata.DefaultView;
            dgvdata.IsReadOnly = true;


        }
    }
}
