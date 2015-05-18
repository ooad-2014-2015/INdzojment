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

namespace WpfApplication1
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

        private void ptica_button_Click(object sender, RoutedEventArgs e)
        {
            ptica_window window = new ptica_window();
            window.ShowDialog();
        }

        private void pas_button_Click(object sender, RoutedEventArgs e)
        {
            pas_window window = new pas_window();
            window.ShowDialog();
        }

        private void macka_button_Click(object sender, RoutedEventArgs e)
        {
            macka_window window = new macka_window();
            window.ShowDialog();

        }

        private void zec_button_Click(object sender, RoutedEventArgs e)
        {
            zec_window window = new zec_window();
            window.ShowDialog();
        }

        private void hrcak_button_Click(object sender, RoutedEventArgs e)
        {
            hrcak_window window = new hrcak_window();
            window.ShowDialog();
            
        }

        

       
    }
}
