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

namespace Act_1_DependProp
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



        public static readonly DependencyProperty CurrentTimeProperty =
        DependencyProperty.Register(
            "CurrentTime",
            typeof(DateTime),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(DateTime.Now, OnCurrentTimePropertyChanged, OnCoerceCurrentTimeProperty));

       
        public DateTime CurrentTime
        {
            get { return (DateTime)GetValue(CurrentTimeProperty); }
            set { SetValue(CurrentTimeProperty, value); }
        }

        // Coerce method to enforce rules on CurrentTime
        private static object OnCoerceCurrentTimeProperty(DependencyObject d, object baseValue)
        {
            DateTime newValue = (DateTime)baseValue;
            if (newValue > DateTime.Now)
            {
                return DateTime.Now; // Coerce to current time if the new value is in the future
            }
            return baseValue; // Return the original value if no coercion is needed
        }

        // Property changed callback
        private static void OnCurrentTimePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DateTime newValue = (DateTime)e.NewValue;

            // Validation logic
            ValidateCurrentTime(newValue);
        }

        // Validation method
        private static void ValidateCurrentTime(DateTime value)
        {
            if (value < DateTime.MinValue || value > DateTime.MaxValue)
            {
                throw new ArgumentOutOfRangeException("CurrentTime must be a valid DateTime.");
            }
        }









    }
}
