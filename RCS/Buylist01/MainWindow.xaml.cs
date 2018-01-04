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

namespace Buylist01
{
    using System.Collections.ObjectModel;
    using System.IO;

    /// <summary> 
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            BuyListItemName.Text = "Lūdzu ievadiet pirkumu";
            BuyItemsList.Add("Āboli");
            BuyItemsList.Add("Bumbieri");

            BuyItemsListControl.ItemsSource = BuyItemsList;
        }

        private void AddListItemButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredItemToBuy = BuyListItemName.Text;
            BuyListItemName.Text = "";

            BuyItemsList.Add(enteredItemToBuy);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines(@"C:\mans_failsigas , BuyItemsList);
    }
}