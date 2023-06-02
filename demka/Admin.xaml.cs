using System;
using System.Collections.Generic;
using System.Data;
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
using demka.DataSet1TableAdapters;

namespace demka
{

    
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {

        TovarTableAdapter tovar = new TovarTableAdapter();
        public Admin()
        {
            InitializeComponent();
            ListView.ItemsSource = tovar.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //new TovarTableAdapter.InsertQuery
            tovar.InsertQuery(TovarBox.Text, Convert.ToDouble( CenaBox.Text ));
            ListView.ItemsSource = tovar.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (ListView.SelectedItem as DataRowView).Row[0];
            tovar.DeleteQuery(Convert.ToInt32(id));
            ListView.ItemsSource = tovar.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
                object id = (ListView.SelectedItem as DataRowView).Row[0];
                tovar.UpdateQuery(TovarBox.Text, Convert.ToDouble(CenaBox.Text), Convert.ToInt32(id));
                ListView.ItemsSource = tovar.GetData();
            
        }
    }
}
