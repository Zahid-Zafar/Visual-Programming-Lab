using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace CricketTeamManager
{
    public partial class MainWindow : Window
    {
        // ObservableCollection to hold player names
        public ObservableCollection<string> Players { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Players = new ObservableCollection<string>();
            PlayerListBox.ItemsSource = Players; // Bind ListBox to Players collection
        }

        // Add player event
        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            string playerName = PlayerNameTextBox.Text.Trim();

            // Validation: Prevent empty or duplicate names
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Player name cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Players.Contains(playerName))
            {
                MessageBox.Show("Player already exists in the team.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Add player to the ObservableCollection
            Players.Add(playerName);
            MessageBox.Show($"Player '{playerName}' added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            PlayerNameTextBox.Clear(); // Clear the input
        }

        // Remove player event
        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a player to remove.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string playerName = PlayerListBox.SelectedItem.ToString();
            Players.Remove(playerName);
            MessageBox.Show($"Player '{playerName}' removed successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}