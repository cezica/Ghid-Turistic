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
using System.IO;

namespace ghid
{
    /// <summary>
    /// Interaction logic for W_County.xaml
    /// </summary>
    public partial class W_County : Window
    {
        public W_County(string name)
        {
            InitializeComponent();
            initialize(name);
        }

        private void initialize(string name)
        {
            string url = $"/county/{name}.jpg";
            Background.Source = new BitmapImage(new Uri(url,UriKind.Relative));
            this.UpdateLayout();
        }
    }
}
