﻿using System;
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
using MySql.Data.MySqlClient;

namespace CaféToepassing_WPF
{
    /// <summary>
    /// Interaction logic for Gebruiker.xaml
    /// </summary>
    public partial class Gebruiker : Window
    {
        private Controller _controller;
        Bestelling _bestelling1;
        public Gebruiker()
        {
            InitializeComponent();
            _controller = new Controller();
            cbxProducten.ItemsSource = _controller.getProducten();
        }
        private void btnVoegBestellingToe_Click(object sender, RoutedEventArgs e)
        {
            _bestelling1 = new Bestelling(Convert.ToDateTime(tbxDatum.Text), tbxBetaald.Text, Convert.ToInt32(tbxTafelNummer.Text), tbxemailadress.Text);
            _controller.addBestelling(_bestelling1);
            ClearInput();
        }
        private void ClearInput()
        {
        }
        private void btnVoegProductToe_Click(object sender, RoutedEventArgs e)
        {
            _bestelling1 = new Bestelling(Convert.ToDateTime(tbxDatum.Text), tbxBetaald.Text, Convert.ToInt32(tbxTafelNummer.Text), tbxemailadress.Text);
            Producten product = (Producten)(cbxProducten.SelectedItem);
            ProductenInBestelling ProductInBestelling = new ProductenInBestelling(_bestelling1.IdBestelling, product.IdProduct, Convert.ToDouble(tbxAantal.Text)); //mijn bestellingid werkt nog niet
            _controller.addProductenInBestelling(ProductInBestelling);
            ClearInput();
        }
    }
}
