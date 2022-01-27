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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "") MessageBox.Show("Uzupełnij pola");

            else lblOut.Content=Convert.ToString(Int32.Parse(txtA.Text) + Int32.Parse(txtB.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "") MessageBox.Show("Uzupełnij pola");

            else lblOut.Content = Convert.ToString(Int32.Parse(txtA.Text) - Int32.Parse(txtB.Text));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "") MessageBox.Show("Uzupełnij pola");

            else lblOut.Content = Convert.ToString(Int32.Parse(txtA.Text) * Int32.Parse(txtB.Text));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (txtA.Text == "" || txtB.Text == "") MessageBox.Show("Uzupełnij pola");
            else if(Int32.Parse(txtB.Text) == 0) MessageBox.Show("Dzielenie przez zero????????????");
            else lblOut.Content = Convert.ToString(Int32.Parse(txtA.Text) / Int32.Parse(txtB.Text));
        }
    }
}
