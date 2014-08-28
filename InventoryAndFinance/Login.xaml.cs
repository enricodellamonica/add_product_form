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
using DataLayer;


namespace InventoryAndFinance {
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        private Query q;
        public Login() {
            InitializeComponent();
            q = new Query();
            new MockUser("fabio","scopel");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        if(q.CheckUserAuthetication(TBUser.Text, TBPassword.Text)) {

            this.Hide();
            var win = new MainWindow();
            win.Show();

        }
        else {
            MessageBox.Show("username or password is invalid");

            }
        }
        }
    }
