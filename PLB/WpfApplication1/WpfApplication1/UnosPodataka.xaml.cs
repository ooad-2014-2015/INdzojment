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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UnosPodataka.xaml
    /// </summary>
    public partial class UnosPodataka : Window
    {
        public UnosPodataka()
        {
            InitializeComponent();
        }

        private void b_dalje_Click(object sender, RoutedEventArgs e)
        {
            tab_placanje.Visibility = Visibility.Visible;
            glavniTab.SelectedIndex = 1;
        }
    }
}
