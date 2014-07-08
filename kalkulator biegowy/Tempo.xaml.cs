using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace kalkulator_biegowy
{
    public partial class Tempo : PhoneApplicationPage
    {
        public Tempo()
        {
            InitializeComponent();
        }
        private void przycisk_Click(object sender, RoutedEventArgs e)
        {

            if ((DystansBox.Text == "") | (hBox.Text == "") | (mBox.Text == "") | (sBox.Text == ""))
            {
                MessageBox.Show("Wpisz dystans i czas!");

            }
            else
            {
                double dystans = Convert.ToDouble(DystansBox.Text);
                double h = Convert.ToDouble(hBox.Text);
                double m = Convert.ToDouble(mBox.Text);
                double s = Convert.ToDouble(sBox.Text);
                if ((m > 60) | (s > 60))
                {
                    MessageBox.Show("Zarówno minuty jak i sekundy nie mogą mieć wartości większej niż 60!");
                }
                else
                {
                    
                    double wynik = ((h * 60 + m + s / 60) / (dystans / 1000));
                    double reszta = ((h * 60 + m + s / 60) % (dystans / 1000));
                    double sekundy = (reszta * 60) / (dystans / 1000);
                    string g = String.Format("{00:00}", h);
                    string min = String.Format("{00:00}", m);
                    string sek = String.Format("{00:00}", s);
                    double wyni = Math.Floor(wynik);
                    double seku = Math.Round(sekundy);
                    string wyn = String.Format("{00:00}", wyni);
                    string sek2 = String.Format("{00:00}", seku);

                    WynikBox.Text = "Pokonując dystans  " + dystans + " metrów w czasie " + g + ":" + min + ":" + sek + " Twoje średnie tempo wyniesie " + wyn + ":" + sek2 + " min/km.";

                }
            }

        }

        private void PowrotButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}
