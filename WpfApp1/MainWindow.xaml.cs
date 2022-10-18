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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Button btn = (Button)sender;

            int random = new Random().Next(typeof(Brushes).GetProperties().Length);
            btn.Background = (Brush)typeof(Brushes).GetProperties()[random].GetValue(null, null)!;

            StringBuilder sb = new();

            sb.Append($"Name: {btn.Name}\n");
            sb.Append($"Text: {btn.Content}\n");
            sb.Append($"Color: {btn.Background}\n");
            sb.Append($"FontSize: {btn.FontSize}\n");

            MessageBox.Show(sb.ToString(), "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void buttonRight_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Button btn = (Button)sender;

            btn.Visibility = Visibility.Collapsed;
            Title = btn.Content.ToString();
        }
    }
}
