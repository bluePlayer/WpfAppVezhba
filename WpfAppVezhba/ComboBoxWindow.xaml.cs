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
    /// Interaction logic for ComboBoxWindow.xaml
    /// </summary>
    public partial class ComboBoxWindow : Window
    {
        Vezhba vezhba;
        public ComboBoxWindow()
        {
            InitializeComponent();

            vezhba = new Vezhba();
            DataContext = vezhba;
        }
    }
}
