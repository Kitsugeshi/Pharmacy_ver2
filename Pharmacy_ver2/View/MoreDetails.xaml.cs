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
using Pharmacy_ver2.ViewModel; 

namespace Pharmacy_ver2.View
{
    /// <summary>
    /// Логика взаимодействия для MoreDetails.xaml
    /// </summary>
    public partial class MoreDetails : Window
    {
        public MoreDetails(Drug chosenD)
        {
            InitializeComponent();

            DataContext = new MDVM(chosenD);
        }
    }
}
