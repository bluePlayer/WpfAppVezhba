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

namespace WpfAppVezhba
{
    /// <summary>
    /// Interaction logic for ComboBoxPoDenWindow.xaml
    /// </summary>
    public partial class ComboBoxPoDenWindow : Window
    {
        Vezhba vezhba;
        public ComboBoxPoDenWindow()
        {
            InitializeComponent();

            vezhba = new Vezhba();
            DataContext = vezhba;
        }

        private void smeniNedela_Click(object sender, RoutedEventArgs e)
        {
            //vezhba.method3();
            //vezhba.method4();
            vezhba.method8(new DateTime(2023, 11, 27));
        }

        private void cldr_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (vezhba != null)
            {
                // TODO dodadi kod koj go pechati redniot broj na nedelata vo godinata. 
                DateTime dt = cldr.SelectedDate == null ? DateTime.Today : (DateTime)cldr.SelectedDate;
                vezhba.method8(dt);
                vezhba.method9(dt);
            }
        }

        private void pretNedelaBtn_Click(object sender, RoutedEventArgs e)
        {
            vezhba.prethodnaSedmica();
        }

        private void sledNedelaBtn_Click(object sender, RoutedEventArgs e)
        {
            vezhba.slednaSedmica();
        }

        private void imaVremeChkBox_Checked(object sender, RoutedEventArgs e)
        {
            vezhba.BojaVreme = Brushes.LightGreen;
        }

        private void nemaVremeChkBox_Checked(object sender, RoutedEventArgs e)
        {
            vezhba.BojaVreme = Brushes.LightCoral;
        }

        private void imaPomalkuVremeChkBox_Checked(object sender, RoutedEventArgs e)
        {
            vezhba.BojaVreme = Brushes.Orange;
        }

        private void sedmicaNovaDG_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                foreach (Sedmica sedmica in vezhba.MesecPoSedmici)
                    sedmica.SoberiOdrabotenoVreme();
            }
        }
    }
}
