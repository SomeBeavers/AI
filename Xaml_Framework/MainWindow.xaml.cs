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

namespace Xaml_Framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _clickCounter;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CoolButton_Click(object sender, RoutedEventArgs e)
        {
            _clickCounter++;
            ClickCounterTextBox.Text = $"Clicks: {_clickCounter}";
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Test()
        {
        }
    }
}
