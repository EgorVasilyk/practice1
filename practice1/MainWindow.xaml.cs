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
using practice1.prac1DataSetTableAdapters;
using System.Data;

namespace practice1
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            

            InitializeComponent();

            

            firmTableAdapter firm = new firmTableAdapter();
            shopTableAdapter shop = new shopTableAdapter();
            phoneTableAdapter phone = new phoneTableAdapter();
            phone_shopTableAdapter phone_ahop = new phone_shopTableAdapter();

            grid.ItemsSource = firm.GetData();

            select.ItemsSource = firm.GetData();
            select.DisplayMemberPath = "firm_name";  
        }

        private void select_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (select.SelectedItem as DataRowView).Row[0];
            MessageBox.Show(cell.ToString());
        }
    }
}
