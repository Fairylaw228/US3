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
using demka.DataSet1TableAdapters;

namespace demka
{
    /// <summary>
    /// Логика взаимодействия для Sotrudnik.xaml
    /// </summary>
    public partial class Sotrudnik : Window
    {
        TovarTableAdapter Tovar = new TovarTableAdapter();
        public Sotrudnik()
        {
            InitializeComponent();
            ListView.ItemsSource = Tovar.GetData();
            
        }

        
    }
}
