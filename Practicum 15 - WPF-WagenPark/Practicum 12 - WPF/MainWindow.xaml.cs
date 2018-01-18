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

namespace PracticumWPF_WagenPark
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WagenPark wagenpark = new WagenPark();
        private List<Garage> garages = new List<Garage>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonVoegToe_Click(object sender, RoutedEventArgs e)
        {
            wagenpark.SchrijfWagenIn(new Wagen
            {
                Nummerplaat = textBoxNummerplaat.Text,
                Merk = textBoxMerk.Text,
                Schade = 0
            });
            MessageBox.Show("De wagen werd ingeschreven");
            textBoxNummerplaat.Clear();
            textBoxMerk.Clear();
        }

        private void buttonExpertise_Click(object sender, RoutedEventArgs e)
        {
            ExpertiseBureau expertiseBureau = new ExpertiseBureau();
            expertiseBureau.VoerExpertiseUit(wagenpark.Wagens);
            MessageBox.Show("De expertise werd uitgevoerd");
        }

        private void buttonOverzicht_Click(object sender, RoutedEventArgs e)
        {
            textBoxWagenpark.Text = wagenpark.GeefOverzicht();
        }

        private void buttonVoegGarageToe_Click(object sender, RoutedEventArgs e)
        {
            garages.Add(new Garage { Merk = textBoxGarageMerk.Text, Naam = textBoxGarageNaam.Text});
            MessageBox.Show("Garage toegevoegd");
            textBoxGarageNaam.Clear();
            textBoxGarageMerk.Clear();
        }

        private void buttonReparatie_Click(object sender, RoutedEventArgs e)
        {
            foreach (Wagen wagen in wagenpark.Wagens)
            {
                foreach (Garage garage in garages)
                {
                    if (garage.Merk == wagen.Merk)
                    {
                        wagen.Schade = 0;
                        MessageBox.Show("Wagen " + wagen.Nummerplaat + " werd gerepareerd");
                    }
                }
            }
        }
    }
}
