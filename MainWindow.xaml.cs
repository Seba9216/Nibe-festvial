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

namespace Hej_Bestllingsapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

     

        public MainWindow() {
            InitializeComponent();

            this.DataContext = this;
        }

        private bool End;

        

       

        private int sum;



        private void Biletter_TextChanged(object sender, TextChangedEventArgs e) {



        }

        private void case1_Click(object sender, RoutedEventArgs e) {

        }

        private void Torsdagsbillet_Click(object sender, RoutedEventArgs e) {

        }

        private void case2_Click(object sender, RoutedEventArgs e) {

        }

        private void case3_Click(object sender, RoutedEventArgs e) {

        }

        private void case4_Click(object sender, RoutedEventArgs e) {

        }
    }
}
