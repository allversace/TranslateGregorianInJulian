using System;
using System.Windows;

namespace WpfApp12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate = DataPicker.SelectedDate.Value;
            double julianDate = selectedDate.ToOADate() - 13;
            DateTime julianDateTime = DateTime.FromOADate(julianDate);
            result.Text = julianDateTime.ToString("dd.MM.yyyy");
        }
    }
}
