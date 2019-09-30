using System;
using System.Collections;
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

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> items = new List<string>();
        private double subTotal = 0.0;
        private double tax = 0.0;
        private double total = 0.0;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void statusBarLogoMoustDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.centennialcollege.ca/");
            
        }

        private void ElectronicsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var price = getPrice(ElectronicsComboBox.SelectedIndex, "electronics");
            items.Add(ElectronicsComboBox.SelectedValue.ToString() + "\t" + price.ToString("C2"));;
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = items;
            subTotal += price;
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = 0.13 * subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");
        }
        private void BooksComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var price = getPrice(BooksComboBox.SelectedIndex, "books");
            items.Add(BooksComboBox.SelectedValue.ToString() + "\t" + price.ToString("C2")); ;
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = items;
            subTotal += price;
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = 0.13 * subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");
        }

        private void JewelryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var price = getPrice(JewelryComboBox.SelectedIndex, "jewelry");
            items.Add(JewelryComboBox.SelectedValue.ToString() + "\t" + price.ToString("C2")); ;
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = items;
            subTotal += price;
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = 0.13 * subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");
        }

        private void ToysComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var price = getPrice(ToysComboBox.SelectedIndex, "toys");
            items.Add(ToysComboBox.SelectedValue.ToString() + "\t" + price.ToString("C2")); ;
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = items;
            subTotal += price;
            subtotalTextBox.Text = subTotal.ToString("N2");
            tax = 0.13 * subTotal;
            taxTextBox.Text = tax.ToString("N2");
            total = subTotal + tax;
            totalTextBox.Text = total.ToString("N2");
        }

        public double getPrice(int indexNum, string itemType)
        {
            double price = 0.0;
            if (itemType == "electronics")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 100;
                        break;
                    case 1:
                        price = 200;
                        break;
                    case 2:
                        price = 300;
                        break;
                }
            }
            else if (itemType == "books")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 10;
                        break;
                    case 1:
                        price = 15;
                        break;
                    case 2:
                        price = 20;
                        break;
                }
            }
            else if (itemType == "jewelry")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 5.95;
                        break;
                    case 1:
                        price = 3.95;
                        break;
                    case 2:
                        price = 5.95;
                        break;
                }
            }
            else if (itemType == "toys")
            {
                switch (indexNum)
                {
                    case 0:
                        price = 20;
                        break;
                    case 1:
                        price = 30;
                        break;
                    case 2:
                        price = 40;
                        break;
                }
            }

            return price;
            ;

        }

        private void ClearBill_Click(object sender, RoutedEventArgs e)
        {
            subTotal = 0.0;
            tax = 0.0;
            total = 0.0;
            items.Clear();
            listbox1.ItemsSource = null;
            listbox1.ItemsSource = items;
            subtotalTextBox.Text = subTotal.ToString("N2");
            taxTextBox.Text = tax.ToString("N2");
            totalTextBox.Text = total.ToString("N2");
        }
    }
}
