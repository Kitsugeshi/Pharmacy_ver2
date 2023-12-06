using Pharmacy_ver2.ViewModel;
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

namespace Pharmacy_ver2.View
{
    /// <summary>
    /// Логика взаимодействия для NewDrug.xaml
    /// </summary>
    public partial class NewDrug : Window
    {
        public NewDrug()
        {
            InitializeComponent();

            DataContext = new NewDrugVM();
        }
    }
}
