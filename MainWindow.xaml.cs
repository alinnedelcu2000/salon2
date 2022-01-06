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

namespace salon2
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


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        private void contact(object sender, RoutedEventArgs e)
        {
            MainWindow.Content = new contact();
        }

        private void program(object sender, RoutedEventArgs e)
        {
            MainWindow.Content = new Program();
        }

        private void servicii(object sender, RoutedEventArgs e)
        {
            MainWindow.Content = new Servicii();
        }

        private void minimize(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serviciibtn(object sender, RoutedEventArgs e)
        {

        }

        private void programbtn(object sender, RoutedEventArgs e)
        {

        }

        private void contactbtn(object sender, RoutedEventArgs e)
        {

        }
    }
}
