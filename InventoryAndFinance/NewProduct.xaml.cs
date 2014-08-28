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
    /// Interaction logic for NewProduct.xaml
    /// </summary>
    public partial class NewProduct : Window
    {
        public Query q;
        public NewProduct() {
            
            InitializeComponent();
            q=new Query();
            }

        private void BTSave_Click(object sender, RoutedEventArgs e) {
            q.AddProduct(Id.Text, TitleBox.Text, Version.Text,Description.Text,Url.Text, VersionUrl.Text);

            }

        private void BtReset_Click(object sender, RoutedEventArgs e)
        {
        foreach (UIElement element in myGrid.Children)
        {
            var textbox = element as TextBox;
            if (textbox != null)
            {
            textbox.Text = String.Empty;
            }
        }


            }
        }
        
    }
