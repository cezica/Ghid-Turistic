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

namespace ghid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double x, y;
        public MainWindow()
        {
            InitializeComponent();
        }
        /////////////////////////////////////////////////////

        private void zoom_in_region(object sender)
        {
            Image img = (Image)sender;
            //pentru a veni imaginea in fata
            Panel.SetZIndex(img,10);

            double plus = 0;
            x = img.Width;
            y = img.Height;
            while (plus < 100)
            {
                plus += 0.01;
                img.Width += 0.01;
                img.Height += 0.01;
                this.UpdateLayout();
            }
        }

        private void zoom_out_region(object sender)
        {
            Image img = (Image)sender;

            img.Width = x;
            img.Height = y;

            //pentru a veni imaginea in spate
            Panel.SetZIndex(img, 1);
            this.UpdateLayout();
        }

        private void click_region(object sender)
        {
            W_Region window = new W_Region(sender);
            window.Top = this.Top;
            window.Left = this.Left;
            window.Show();
            this.Hide();
            this.Close();
        }

        /////////////////////////////////////////////////////
        #region zoom 
        private void Transilvania_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Transilvania_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        private void Crisana_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        private void Crisana_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Banat_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        private void Banat_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Oltenia_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        private void Oltenia_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Muntenia_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Muntenia_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        private void Moldova_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Moldova_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        private void Dobrogea_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Dobrogea_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        private void Bucovina_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Bucovina_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        private void Maramures_MouseEnter(object sender, MouseEventArgs e)
        {
            zoom_in_region(sender);
        }

        private void Maramures_MouseLeave(object sender, MouseEventArgs e)
        {
            zoom_out_region(sender);
        }

        #endregion

        #region select region
        private void Moldova_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        private void Oltenia_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        private void Muntenia_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        private void Dobrogea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        private void Bucovina_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        private void Maramures_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        private void Transilvania_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        private void Crisana_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        private void Banat_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            click_region(sender);
        }

        #endregion
    }
}
