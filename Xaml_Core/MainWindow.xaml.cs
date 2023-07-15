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

namespace Xaml_Core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _clickCount;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CoolButton_Click(object sender, RoutedEventArgs e)
        {
            _clickCount++;
            ClickCounterTextBox.Text = _clickCount.ToString();
        }

private void ResetButton_Click(object sender, RoutedEventArgs e)
{
            // Reset the click counter
            _clickCount = 0;
    // Update the ClickCounterTextBox
    ClickCounterTextBox.Text = "0";
}

    }
}
