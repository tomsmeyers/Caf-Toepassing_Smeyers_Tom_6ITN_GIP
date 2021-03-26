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
using System.Windows.Shapes;
using CaféToepassing_Domain.Business;

namespace CaféToepassing_WPF
{
    /// <summary>
    /// Interaction logic for Inlog.xaml
    /// </summary>
    public partial class Eigenaar : Window
    {
        //velden
        private Controller _controller;
        public Eigenaar()
        {
            InitializeComponent();
            _controller = new Controller();
            ClearInput();
        }

        private void btnProducten_Click(object sender, RoutedEventArgs e)
        {
            lbxCaféToepassing.ItemsSource = _controller.getProducten();
            lbxCaféToepassing.Items.Refresh();
        }
        private void btnTafels_Click(object sender, RoutedEventArgs e)
        {
            lbxCaféToepassing.ItemsSource = _controller.GetTafels();
            lbxCaféToepassing.Items.Refresh();
        }
        private void btnProductenInBestelling_Click(object sender, RoutedEventArgs e)
        {
            lbxCaféToepassing.ItemsSource = _controller.GetProductenInBestelling();
            lbxCaféToepassing.Items.Refresh();
        }

        private void btnBestellingen_Click(object sender, RoutedEventArgs e)
        {
            lbxCaféToepassing.ItemsSource = _controller.GetBestellingen();
            lbxCaféToepassing.Items.Refresh();
        }

        private void btnVoegProductToe_Click(object sender, RoutedEventArgs e)
        {
            Producten product = new Producten(tbxProductNaam.Text, Convert.ToDouble(tbxPrijs.Text));
            _controller.addProducten(product);
            ClearInput();
        }

        private void btnVoegTafelToe_Click(object sender, RoutedEventArgs e)
        {
            Tafel tafel = new Tafel(tbxPositie.Text);
            _controller.addTafel(tafel);
            ClearInput();
        }
        private void ClearInput()
        {
            tbxPositie.Clear();
            tbxPrijs.Clear();
            tbxProductNaam.Clear();
        }

    }
}
