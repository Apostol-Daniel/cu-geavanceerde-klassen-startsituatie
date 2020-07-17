using GeavanceerdeKlassen.Lib;
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

namespace GeavanceerdeKlassen.Wpf
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

        private void BtnToonAuto_Click(object sender, RoutedEventArgs e)
        {
            Auto nieuweAuto = new Auto();
            nieuweAuto.AantalDeuren = 4;
            nieuweAuto.HeeftEenMotor = true;
            nieuweAuto.Merk = "Audi";
            lblDetails.Content = nieuweAuto.ToonDetails();
        }

        private void BtnToonFiets_Click(object sender, RoutedEventArgs e)
        {
            Fiets nieuweFiets = new Fiets();
            nieuweFiets.HeeftSpatboorden = true;
            nieuweFiets.HeeftEenMotor = false;
            nieuweFiets.Merk = "Cube";
        }

        private void btnToonVoertuig_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnMaakVervoersmiddelen_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
