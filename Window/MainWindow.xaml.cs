using PhoenixPR.Window;
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

namespace PhoenixPR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthoriBtn_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
        }

        private void ForgPswrdBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
