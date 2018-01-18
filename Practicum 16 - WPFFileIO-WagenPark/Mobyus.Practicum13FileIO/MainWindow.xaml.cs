using System;
using System.Collections.Generic;
using System.IO;
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

namespace Mobyus.PracticumWPFFileIO_WagenPark
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

            textBoxWagenpark.Text = wagenpark.GeefOverzicht();
            textBoxNummerplaat.Clear();
            textBoxMerk.Clear();
        }

        private void buttonExpertise_Click(object sender, RoutedEventArgs e)
        {
            ExpertiseBureau expertiseBureau = new ExpertiseBureau();
            expertiseBureau.VoerExpertiseUit(wagenpark.Wagens);
            MessageBox.Show("De expertise werd uitgevoerd");
            textBoxWagenpark.Text = wagenpark.GeefOverzicht();
        }

        private void buttonOverzicht_Click(object sender, RoutedEventArgs e)
        {
            textBoxWagenpark.Text = wagenpark.GeefOverzicht();
        }

        private void buttonVoegGarageToe_Click(object sender, RoutedEventArgs e)
        {
            garages.Add(new Garage { Merk = textBoxGarageMerk.Text, Naam = textBoxGarageNaam.Text });
            textBoxGarageNaam.Clear();
            textBoxGarageMerk.Clear();
            GarageOverzicht();
        }

        private void GarageOverzicht()
        {
            textBoxGarages.Clear();
            textBoxGarages.Text = "Overzicht garages:" + Environment.NewLine;
            foreach (Garage garage in garages)
            {
                textBoxGarages.Text += ("Naam: " + garage.Naam + "  Merk: " + garage.Merk + Environment.NewLine);
            }
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
            textBoxWagenpark.Text = wagenpark.GeefOverzicht();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            wagenpark.WagensInladen();
            textBoxWagenpark.Text = wagenpark.GeefOverzicht();
        }

        private void buttonWegschrijven_Click(object sender, RoutedEventArgs e)
        {
            wagenpark.WagensWegschrijven();
            MessageBox.Show("De wagens werden in een file weggeschreven");
        }

        private void buttonInladenGarages_Click(object sender, RoutedEventArgs e)
        {
            garages.Clear();
            string[] garageRecords = File.ReadAllLines("garages.txt");
            foreach (string garageRecord in garageRecords)
            {
                string[] garageProperties = garageRecord.Split('\t');
                garages.Add(new Garage
                {
                    Merk = garageProperties[0],
                    Naam = garageProperties[1]
                });
            }
            GarageOverzicht();
        }

        private void buttonWegschrijvenGarages_Click(object sender, RoutedEventArgs e)
        {
            string output = string.Empty;
            foreach (Garage garage in garages)
            {
                output += (garage.Merk + "\t" + garage.Naam + Environment.NewLine);
            }
            File.WriteAllText("garages.txt", output);
            MessageBox.Show("De garages werden weggeschreven.");
        }
    }
}
