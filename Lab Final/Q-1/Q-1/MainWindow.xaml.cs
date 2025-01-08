using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace StudentProgressTracker
{
    public partial class MainWindow : Window
    {
        private string connectionString = "Data Source=DESKTOP-I7R5JRM;Initial Catalog=Record;Integrated Security=True;";

        public ObservableCollection<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Initialize the ObservableCollection
            Students = new ObservableCollection<Student>();

            // Bind data to DataGrid
            StudentDataGrid.ItemsSource = Students;

            // Add grades and subjects to ComboBoxes
            GradeComboBox.ItemsSource = new[] { "A", "B", "C", "D", "F" };
            SubjectComboBox.ItemsSource = new[] { "Math", "Physics", "Chemistry", "Biology" };

            // Load data from the database
            LoadStudentsFromDatabase();
        }

        private void LoadStudentsFromDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Name, Grades, Subject, Marks, Attendance FROM StudRecord";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    Students.Clear();
                    while (reader.Read())
                    {
                        Students.Add(new Student
                        {
                            Name = reader["Name"].ToString(),
                            Grade = reader["Grades"].ToString(),
                            Subject = reader["Subject"].ToString(),
                            Marks = Convert.ToInt32(reader["Marks"]),
                            Attendance = Convert.ToDouble(reader["Attendance"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Students (Name, Grades, Subject, Marks, Attendance) VALUES (@Name, @Grades, @Subject, @Marks, @Attendance)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", "New Student");
                    command.Parameters.AddWithValue("@Grades", "C");
                    command.Parameters.AddWithValue("@Subject", "Chemistry");
                    command.Parameters.AddWithValue("@Marks", 70);
                    command.Parameters.AddWithValue("@Attendance", 85);

                    command.ExecuteNonQuery();
                }

                // Reload data from the database
                LoadStudentsFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}");
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (StudentDataGrid.SelectedItem is Student selectedStudent)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE Students SET Grade = @Grade, Marks = @Marks WHERE Name = @Name AND Subject = @Subject";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", selectedStudent.Name);
                        command.Parameters.AddWithValue("@Grade", selectedStudent.Grade);
                        command.Parameters.AddWithValue("@Subject", selectedStudent.Subject);
                        command.Parameters.AddWithValue("@Marks", selectedStudent.Marks + 5); // Example modification

                        command.ExecuteNonQuery();
                    }

                    // Reload data from the database
                    LoadStudentsFromDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error editing student: {ex.Message}");
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (StudentDataGrid.SelectedItem is Student selectedStudent)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Students WHERE Name = @Name AND Subject = @Subject";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", selectedStudent.Name);
                        command.Parameters.AddWithValue("@Subject", selectedStudent.Subject);

                        command.ExecuteNonQuery();
                    }

                    // Reload data from the database
                    LoadStudentsFromDatabase();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting student: {ex.Message}");
                }
            }
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedGrade = GradeComboBox.Text;
            string selectedSubject = SubjectComboBox.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Name, Grade, Subject, Marks, Attendance FROM Students WHERE (Grade = @Grade OR @Grade IS NULL) AND (Subject = @Subject OR @Subject IS NULL)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Grade", string.IsNullOrEmpty(selectedGrade) ? (object)DBNull.Value : selectedGrade);
                    command.Parameters.AddWithValue("@Subject", string.IsNullOrEmpty(selectedSubject) ? (object)DBNull.Value : selectedSubject);

                    SqlDataReader reader = command.ExecuteReader();

                    Students.Clear();
                    while (reader.Read())
                    {
                        Students.Add(new Student
                        {
                            Name = reader["Name"].ToString(),
                            Grade = reader["Grade"].ToString(),
                            Subject = reader["Subject"].ToString(),
                            Marks = Convert.ToInt32(reader["Marks"]),
                            Attendance = Convert.ToDouble(reader["Attendance"])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering students: {ex.Message}");
            }
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private string name;
        private string grade;
        private string subject;
        private int marks;
        private double attendance;

        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Grade
        {
            get => grade;
            set { grade = value; OnPropertyChanged(nameof(Grade)); }
        }

        public string Subject
        {
            get => subject;
            set { subject = value; OnPropertyChanged(nameof(Subject)); }
        }

        public int Marks
        {
            get => marks;
            set { marks = value; OnPropertyChanged(nameof(Marks)); }
        }

        public double Attendance
        {
            get => attendance;
            set { attendance = value; OnPropertyChanged(nameof(Attendance)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}