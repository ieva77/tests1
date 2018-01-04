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

namespace Bylist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BuyListItemName.Text = "Lūdzu ievadiet pirkumu";
        }
        {
        }

        private void AddListItemButton_Click(object sender, RoutedEventArgs e)
        {
            // izvelkam vērību no teksta lauka
            string input = this.BuyListItemName.Text;
            // nodzēšam vērtību teksta laukā
            this.BuyListItemName.Text = "";

            // Ierakstam vērību teksta blokā
            this.BuyListItemName.Text = input;
        }
    }
}
