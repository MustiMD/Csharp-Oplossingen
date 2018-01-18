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

namespace ExamenOef2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Netwerk netwerk = new Netwerk();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonVoegToe_Click(object sender, RoutedEventArgs e)
        {
            Computer computer = new Computer(textboxMAC.Text, textboxModel.Text);
            
            if (!netwerk.Computers.ContainsKey(computer.MAC))
            {
                MessageBox.Show(netwerk.VoegComputerToe(computer));
                listboxOverview.Items.Add(computer);
            }
            else
            {
                MessageBox.Show("De computer is al aanwezig in het netwerk");
            }
            textboxMAC.Clear();
            textboxModel.Clear();
        }

        private void buttonVerwijder_Click(object sender, RoutedEventArgs e)
        {
            Computer computer = listboxOverview.SelectedItem as Computer;
            netwerk.Computers.Remove(computer.MAC);
            netwerk.IP.Add(computer.IPaddress);
            listboxOverview.Items.Remove(listboxOverview.SelectedItem);
            labelSelectie.Content = "";

        }

        private void listboxOverview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Computer computer = listboxOverview.SelectedItem as Computer;
            if (listboxOverview.SelectedItem != null)
            {
                labelSelectie.Content = computer.Overzicht();
            }
            
        }
    }
}
