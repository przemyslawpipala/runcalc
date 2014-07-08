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
    public partial class Czas : PhoneApplicationPage
    {
        public Czas()
        {
            InitializeComponent();
        }
        private void przycisk_Click(object sender, RoutedEventArgs e)
        {

            if ((PredkoscMinBox.Text == "") | (PredkoscSBox.Text == "") | (DystansBox.Text == ""))
            {
                MessageBox.Show("Wpisz prędkość i dystans!");

            }
            else
            {
                //asdasd
                double predkoscmin = Convert.ToDouble(PredkoscMinBox.Text);
                double predkoscs = Convert.ToDouble(PredkoscSBox.Text);
                double dystans = Convert.ToDouble(DystansBox.Text);

                if ((predkoscmin > 60) | (predkoscs > 60))
                {
                    MessageBox.Show("Zarówno minuty jak i sekundy nie mogą mieć wartości większej niż 60!");
                }
                else
                {
                    double godzina = (((dystans / 1000) * (predkoscmin * 60 + predkoscs))/3600);
                    double resztagodziny = (((dystans / 1000) * (predkoscmin * 60 + predkoscs)) % 3600);
                    double minuta =(resztagodziny / 60);
                    double sekunda = (resztagodziny % 60);
                    double godz = Math.Floor(godzina);
                    double minu = Math.Floor(minuta);
                    double seku = Math.Floor(sekunda);
                    string vsek = String.Format("{00:00}", predkoscs);
                    string g = String.Format("{00:00}", godz);
                    string min = String.Format("{00:00}", minu);
                    string sek = String.Format("{00:00}", seku);
                    WynikBox.Text = "Bięgnąc tempem " + predkoscmin + ":" + vsek + " pokonasz dystans " + dystans + " metrów w czasie " + g + ":" + min + ":" + sek + ".";

                }
             }
        }

        private void PowrotButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
        }
           

       
            
    }
    
