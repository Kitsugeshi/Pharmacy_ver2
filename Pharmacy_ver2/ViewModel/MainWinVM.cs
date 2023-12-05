using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Pharmacy.View;

namespace Pharmacy.ViewModel
{
    class MainWinVM : PChanged
    {
        RelayCommand? _openStore;
        public RelayCommand OpenStore
        {
            get
            {
                return _openStore! ??
                    (_openStore = new RelayCommand(obj =>
                    {
                        StoreWin storeWindow = new StoreWin();
                        if (storeWindow.ShowDialog() == true)
                        {

                        }
                        //storeWindow.Show();
                    }
                    ));
            }
        }
    }
}
