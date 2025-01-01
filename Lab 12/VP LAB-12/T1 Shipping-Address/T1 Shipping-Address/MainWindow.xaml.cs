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
using Microsoft.VisualBasic;

namespace T1_Shipping_Address
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ViewModel property to bind the selected shipping address
        public string SelectedShippingAddress { get; set; }

        // List to store addresses
        private List<string> addresses = new List<string> { "123 Main St", "456 Elm St", "789 Oak St" };

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this; // Set DataContext for binding
            LoadAddresses();
        }

        // Load the addresses into the ComboBox
        private void LoadAddresses()
        {
            AddressComboBox.ItemsSource = addresses;
            AddressComboBox.SelectedIndex = 0;
        }

        // Update the selected shipping address when selection changes
        private void AddressComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AddressComboBox.SelectedItem != null)
            {
                SelectedShippingAddress = AddressComboBox.SelectedItem.ToString();
            }
        }

        // Add a new address
        private void AddAddressButton_Click(object sender, RoutedEventArgs e)
        {
            string newAddress = Interaction.InputBox("Enter some text:", "Input", "", -1, -1);
            if (!string.IsNullOrWhiteSpace(newAddress))
            {
                addresses.Add(newAddress);
                LoadAddresses();
                AddressComboBox.SelectedItem = newAddress;
            }
        }

        // Update an existing address
        private void UpdateAddressButton_Click(object sender, RoutedEventArgs e)
        {
            if (AddressComboBox.SelectedItem != null)
            {
                string updatedAddress = Interaction.InputBox("Enter updated address:", "Update Address", AddressComboBox.SelectedItem.ToString());  //by Microsoft Visual Libaray

                // TextBox.Text = updatedAddress;
                if (!string.IsNullOrWhiteSpace(updatedAddress))
                {
                    int selectedIndex = AddressComboBox.SelectedIndex;
                    addresses[selectedIndex] = updatedAddress;
                    TextBox.Text = updatedAddress;  
                    LoadAddresses();
                    AddressComboBox.SelectedIndex = selectedIndex;
                }
            }
            else
            {
                MessageBox.Show("Please select an address to update.", "Update Address", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            if (AddressComboBox.SelectedItem != null)
            {
                //SelectedShippingAddress = AddressComboBox.SelectedItem.ToString();
                //TextBox.Text = SelectedShippingAddress;
                var textBox = (System.Windows.Controls.TextBox)sender;
                string newAddress = textBox.Text;
                // Example: You can update the SelectedShippingAddress manually here, if needed
                SelectedShippingAddress = newAddress;
            }
        }

        // Attached Property Helper Class
        public static class ShippingAddressHelper
        {
            // Define the attached property
            public static readonly DependencyProperty SelectedShippingAddressProperty =
                DependencyProperty.RegisterAttached("SelectedShippingAddress", typeof(string), typeof(ShippingAddressHelper), new PropertyMetadata(default(string)));

            // Get method for attached property
            public static string GetSelectedShippingAddress(DependencyObject obj)
            {
                return (string)obj.GetValue(SelectedShippingAddressProperty);
            }

            // Set method for attached property
            public static void SetSelectedShippingAddress(DependencyObject obj, string value)
            {
                obj.SetValue(SelectedShippingAddressProperty, value);
            }
        }
    }
}
    
