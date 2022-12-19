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

namespace ghid
{
    /// <summary>
    /// Interaction logic for W_Region.xaml
    /// </summary>
    public partial class W_Region : Window
    {
        public W_Region(object sender)
        {
            InitializeComponent();

            Image img = (Image)sender;
            this.Title = img.Name;
            put_region(img);
            put_county(img);
        }

        private void put_region(Image img)
        {
            Region.Source = img.Source;
            Region.Name = img.Name;
            this.UpdateLayout();
        }

        //preluare din baza de date!!!
        private void put_county(Image img)
        {
            if (img.Name == "Moldova")
            {
                C1.Margin = new System.Windows.Thickness(390, 320, 0, 0); //coordonate bacau
                C2.Margin = new System.Windows.Thickness(370, 225, 0, 0);//coordonate neamt
                C3.Margin = new System.Windows.Thickness(450, 200, 0, 0);//coordonate iasi
            }
            else if (img.Name == "Transilvania")
            {
                C1.Margin = new System.Windows.Thickness(530, 350, 0, 0); //coordonate brasov
                C2.Margin = new System.Windows.Thickness(360, 240, 0, 0);//coordonate cluj
                C3.Margin = new System.Windows.Thickness(440, 360, 0, 0);//coordonate sibiu
                C4.Margin = new System.Windows.Thickness(290, 350, 0, 0); //coordonate deva
                C4.Visibility = Visibility.Visible;
                C5.Margin = new System.Windows.Thickness(485, 300, 0, 0);//coordonate sighisoara
                C5.Visibility = Visibility.Visible;
            }
            else if (img.Name == "Bucovina")
            {
                C1.Margin = new System.Windows.Thickness(420, 220, 0, 0); //coordonate suceava
                C2.Margin = new System.Windows.Thickness(500, 210, 0, 0);//coordonate botosani
                C3.Margin = new System.Windows.Thickness(320, 260, 0, 0);//coordonate gura humorului
            }
            else if (img.Name == "Oltenia")
            {
                C1.Margin = new System.Windows.Thickness(430, 340, 0, 0); //coordonate craiova
                C2.Margin = new System.Windows.Thickness(420, 265, 0, 0);//coordonate caracal
                C3.Margin = new System.Windows.Thickness(520, 340, 0, 0);//coordonate targu jiu
            }
            else if (img.Name == "Dobrogea")
            {
                C1.Margin = new System.Windows.Thickness(400, 320, 0, 0); //coordonate constanta
                C2.Margin = new System.Windows.Thickness(430, 410, 0, 0);//coordonate mangalia
                C3.Margin = new System.Windows.Thickness(580, 160, 0, 0);//coordonate sulina
            }
            else if (img.Name == "Maramures")
            {
                C1.Margin = new System.Windows.Thickness(350, 170, 0, 0); //coordonate satu mare
                C2.Margin = new System.Windows.Thickness(460, 190, 0, 0);//coordonate baia mare
                C3.Visibility = Visibility.Hidden;
            }
            else if (img.Name == "Muntenia")
            {
                C1.Margin = new System.Windows.Thickness(430, 320, 0, 0); //coordonate bucuresti
                C2.Margin = new System.Windows.Thickness(450, 230, 0, 0);//coordonate ploiesti
                C3.Margin = new System.Windows.Thickness(270, 200, 0, 0);//coordonate curtea de arges
            }
            else if (img.Name == "Crisana")
            {
                C1.Margin = new System.Windows.Thickness(430, 200, 0, 0); //coordonate oradea
                C2.Margin = new System.Windows.Thickness(490, 320, 0, 0);//coordonate stei
                C3.Visibility = Visibility.Hidden;
            }
            else if (img.Name == "Banat")
            {
                C1.Margin = new System.Windows.Thickness(380,200,0,0);//timisoara
                C2.Margin = new System.Windows.Thickness(300,140,0,0);//arad
                C3.Margin = new System.Windows.Thickness(460,240,0,0);//lugoj
            }

            this.UpdateLayout();
        }

        #region click judete
        private void C1_Click(object sender, RoutedEventArgs e)
        {
            //Region.Name
            if (Region.Name == "Moldova")//bacau
            {
                Window w_county = new W_County("Bacau");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Transilvania")
            {
                Window w_county = new W_County("Brasov");//brasov
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Bucovina")//suceava
            {
                Window w_county = new W_County("Suceava");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Banat")//timisoara
            {
                Window w_county = new W_County("Timisoara");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Crisana")//oradea
            {
                Window w_county = new W_County("Oradea");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Maramures")
            {
                Window w_county = new W_County("Satu-Mare");//satu mare
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Dobrogea")//sulina
            {
                Window w_county = new W_County("Sulina");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Muntenia")//bucuresti
            {
                Window w_county = new W_County("Bucuresti");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Oltenia")//craiova
            {
                Window w_county = new W_County("Craiova");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            if (Region.Name == "Moldova")//neamt
            {
                Window w_county = new W_County("Neamt");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Transilvania")
            {
                Window w_county = new W_County("Cluj");//cluj
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Bucovina")//botosani
            {
                Window w_county = new W_County("Botosani");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Banat")//arad
            {
                Window w_county = new W_County("Arad");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Crisana")//arad
            {
                Window w_county = new W_County("Arad");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Maramures")//baia mare
            {
                Window w_county = new W_County("Baia-Mare");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Dobrogea")//constanta
            {
                Window w_county = new W_County("Constanta");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Muntenia")//ploiesti
            {
                Window w_county = new W_County("Ploiesti");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Oltenia")//caracal
            {
                Window w_county = new W_County("Caracal");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            //fara maramures si crisana
            if (Region.Name == "Moldova")//iasi
            {
                Window w_county = new W_County("Iasi");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Transilvania")
            {
                Window w_county = new W_County("Sibiu");//sibiu
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Bucovina")//gura-humorului
            {
                Window w_county = new W_County("Gura-Humorului");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Banat")//lugoj
            {
                Window w_county = new W_County("Lugoj");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Dobrogea")//mangalia
            {
                Window w_county = new W_County("Mangalia");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Muntenia")//curtea de arges
            {
                Window w_county = new W_County("CArges");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
            else if (Region.Name == "Oltenia")//targu jiu
            {
                Window w_county = new W_County("Targu-Jiu");
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {
            //doar transilvania
            if(Region.Name=="Transilvania")
            {
                Window w_county = new W_County("Deva");//deva
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {
            //doar transilvania
            if (Region.Name == "Transilvania")
            {
                Window w_county = new W_County("Sighisoara");//sighisoara
                w_county.Top = this.Top;
                w_county.Left = this.Left;
                w_county.Show();
                this.Hide();
                this.Close();
            }
        }
        #endregion
    }
}
