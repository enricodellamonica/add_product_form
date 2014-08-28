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

namespace InventoryAndFinance {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            }


        private void Click_NewProduct(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var win = new NewProduct();
            win.Show();
        }

        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    }
