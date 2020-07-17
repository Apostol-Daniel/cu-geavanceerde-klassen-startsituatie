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
            lblDetails.Content = nieuweFiets.ToonDetails();
        }

        private void btnToonVoertuig_Click(object sender, RoutedEventArgs e)
        {
            Voertuig nieuweVoertuig = new Voertuig
            {
                HeeftEenMotor = true,
                Merk = "boeing"
            };
            lblDetails.Content = nieuweVoertuig.ToonDetails();
        }

        private void btnMaakVervoersmiddelen_Click(object sender, RoutedEventArgs e)
        {
            Fiets fiets1 = new Fiets
            {
                HeeftEenMotor = true,
                HeeftSpatboorden = true,
                Merk = "Granville"
            };

            Fiets fiets2 = new Fiets
            {
                HeeftEenMotor = false,
                HeeftSpatboorden = false,
                Merk = "Specialized"
            };

            Auto auto1 = new Auto
            {
                AantalDeuren = 3,
                HeeftEenMotor = true,
                Merk = "Audi"
            };

            Auto auto2 = new Auto
            {
                AantalDeuren = 4,
                HeeftEenMotor = true,
                Merk = "Mercedes"
            };

            List<Voertuig> vervorsmiddelen = new List<Voertuig>();

            vervorsmiddelen.Add(fiets1);
            vervorsmiddelen.Add(fiets2);
            vervorsmiddelen.Add(auto1);
            vervorsmiddelen.Add(auto2);

            lblDetails.Content = "";

            foreach (Voertuig voertuig in vervorsmiddelen)
            {
                lblDetails.Content += voertuig.ToonDetails() + Environment.NewLine;
            }

        }
    }
}
