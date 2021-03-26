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
using CaféToepassing_Domain.Business;

namespace CaféToepassing_WPF
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
        private void btnKlant_Click(object sender, RoutedEventArgs e)
        {
            Gebruiker gebruikersvenster = new Gebruiker();
            gebruikersvenster.Show();
            this.Close();
        }

        private void btnEigenaar_Click(object sender, RoutedEventArgs e)
        {
            Eigenaar venster = new Eigenaar();
            venster.Show();
            this.Close();
        }

    }
}
