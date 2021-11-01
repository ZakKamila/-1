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

namespace Туристическое_агенство
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
        }

        private void BtnНазад_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if(MainFrame.CanGoBack)
            {
                BtnНазад.Visibility = Visibility.Visible;
                BtnТур.Visibility = Visibility.Visible;
                BtnОтели.Visibility = Visibility.Visible;
            }
            else
            {
                BtnНазад.Visibility = Visibility.Hidden;
                BtnТур.Visibility = Visibility.Hidden;
                BtnОтели.Visibility = Visibility.Hidden;
            }
        }

        private void BtnТур_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Tours());

        }

            private void BtnОтели_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Hotels());

        }
    }
}
