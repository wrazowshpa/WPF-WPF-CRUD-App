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

namespace Question2
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<StorePartner> storePartnerList = new List<StorePartner>();
        List<string> stringListOfStorePartners = new List<string>();
        int indexTracker = 0;
        public MainWindow()
        {
            InitializeComponent();

            StorePartner firstStorePartner = new StorePartner(indexTracker, "VHF1", "Telus", "O.G. Anunoby", "Manager", "941 Progress Avenue", "Toronto", "Canada");
            storePartnerList.Add(firstStorePartner);
            stringListOfStorePartners.Add(firstStorePartner.ToString());
            indexTracker++;
            
            StorePartner secondStorePartner = new StorePartner(indexTracker, "ASD2", "Asus", "Kobe Beans", "CTO", "1050 Markham Road", "Toronto", "Canada");
            storePartnerList.Add(secondStorePartner);
            stringListOfStorePartners.Add(secondStorePartner.ToString());
            indexTracker++;


            StorePartner thirdStorePartner = new StorePartner(indexTracker, "OIJ9", "Lenovo", "Jet Jamison", "CEO", "173 Brimorton Road", "Toronto", "Canada");
            storePartnerList.Add(thirdStorePartner);
            stringListOfStorePartners.Add(thirdStorePartner.ToString());
            indexTracker++;

            StorePartner fourthStorePartner = new StorePartner(indexTracker, "JOI9", "Playstation", "Karl Anthony", "Benchwarmer", "82 Ellesmere Road", "Toronto", "Canada");
            storePartnerList.Add(fourthStorePartner);
            stringListOfStorePartners.Add(fourthStorePartner.ToString());
            indexTracker++;

            StorePartner fifthStorePartner = new StorePartner(indexTracker, "JJO7", "Apple", "Kawhi Leonard", "Role Player", "121 Bathurst Street", "Toronto", "Canada");
            storePartnerList.Add(fifthStorePartner);
            stringListOfStorePartners.Add(fifthStorePartner.ToString());
            indexTracker++;


            listBox1.ItemsSource = null;
            listBox1.ItemsSource = stringListOfStorePartners;

        }

        private void AddStorePartner_Click(object sender, RoutedEventArgs e)
        {
            StorePartner newStorePartner = new StorePartner(indexTracker, idTextBox.Text, companyNameTextBox.Text, contactNameTextBox.Text, contactTitleTextBox.Text, addressTextBox.Text, cityTextBox.Text, countryTextBox.Text);
            storePartnerList.Add(newStorePartner);
            stringListOfStorePartners.Add(newStorePartner.ToString());
            listBox1.ItemsSource = null;
            listBox1.ItemsSource = stringListOfStorePartners;
            indexTracker++;
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            for (int i = 0; i < storePartnerList.Count; i++)
            {
                if (listBox1.SelectedIndex == storePartnerList[i].IndexNumber)
                {
                    idTextBox.Text = storePartnerList[i].Id;
                    companyNameTextBox.Text = storePartnerList[i].CompanyName;
                    contactNameTextBox.Text = storePartnerList[i].ContactName;
                    contactTitleTextBox.Text = storePartnerList[i].ContactTitle;
                    addressTextBox.Text = storePartnerList[i].Address;
                    cityTextBox.Text = storePartnerList[i].City;
                    countryTextBox.Text = storePartnerList[i].Country;

                    companyNameTextBlock.Text = storePartnerList[i].CompanyName;

                    break;
                }
            }
            
        }

        private void UpdateStorePartner_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < storePartnerList.Count; i++)
            {
                if (listBox1.SelectedIndex == storePartnerList[i].IndexNumber)
                { 
                    storePartnerList[i].Id = idTextBox.Text;
                    storePartnerList[i].CompanyName = companyNameTextBox.Text;
                    storePartnerList[i].ContactName = contactNameTextBox.Text;
                    storePartnerList[i].ContactTitle = contactTitleTextBox.Text;
                    storePartnerList[i].Address = addressTextBox.Text;
                    storePartnerList[i].City = cityTextBox.Text;
                    storePartnerList[i].Country = countryTextBox.Text;

                    stringListOfStorePartners[i] = storePartnerList[i].ToString();
                    listBox1.ItemsSource = null;
                    listBox1.ItemsSource = stringListOfStorePartners;

                    companyNameTextBlock.Text = storePartnerList[i].CompanyName;
                }
            }
        }

        private void DeleteStorePartner_Click(object sender, RoutedEventArgs e)
        {
            indexTracker--;
            for (int i = 0; i < storePartnerList.Count; i++)
            {
                if (listBox1.SelectedIndex == storePartnerList[i].IndexNumber)
                {
                    storePartnerList.Remove(storePartnerList[i]);
                    stringListOfStorePartners.Remove(stringListOfStorePartners[i]);

                    listBox1.ItemsSource = null;
                    listBox1.ItemsSource = stringListOfStorePartners;
                }

            }

            for (int i = 0; i < storePartnerList.Count; i++)
            {
                storePartnerList[i].IndexNumber = i;
            }

        }
    }
}
