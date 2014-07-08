using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
//using System.Math;

namespace kalkulator_biegowy
{
    public partial class Dystans : PhoneApplicationPage
    {
        public Dystans()
        {
            InitializeComponent();
        }
        private void przycisk_Click(object sender, RoutedEventArgs e)
        {

            if ((PredkoscMinBox.Text == "") | (PredkoscSBox.Text == "") | (hBox.Text == "") | (mBox.Text == "") | (sBox.Text == ""))
            {
                MessageBox.Show("Wpisz prędkość i czas!");

            }
            else
            {
                double predkoscmin = Convert.ToDouble(PredkoscMinBox.Text);
                double predkoscs = Convert.ToDouble(PredkoscSBox.Text);
                double h = Convert.ToDouble(hBox.Text);
                double m = Convert.ToDouble(mBox.Text);
                double s = Convert.ToDouble(sBox.Text);
                if ((predkoscmin > 60) | (predkoscs > 60) | (m > 60) | (s > 60))
                {
                    MessageBox.Show("Zarówno minuty jak i sekundy nie mogą mieć wartości większej niż 60!");
                }
                else
                {
                    double wynik = ((h * 60 + m + s / 60) / (predkoscmin + predkoscs / 60)) * 1000;
                    decimal wyswietlwynik = (decimal)wynik;
                    wyswietlwynik = System.Decimal.Round(wyswietlwynik, 0);
                    string g = String.Format("{00:00}", h);
                    string min = String.Format("{00:00}", m);
                    string sek = String.Format("{00:00}", s);
                    //string vmin = String.Format("{0:00}", predkoscmin);
                    string vsek = String.Format("{00:00}", predkoscs);
                    WynikBox.Text = "Biegnąc przez  " + g + ":" + min + ":" + sek + " w tempie równym " + predkoscmin + ":" + vsek + " przebiegniesz dystans " + wyswietlwynik + " metrów.";

                }
            }

        }

        private void PowrotButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}
