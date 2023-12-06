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
using Pharmacy_ver2.DataContext;
using Pharmacy_ver2.View;

namespace Pharmacy.ViewModel
{
    class MainWinVM : PChanged
    {
        RelayCommand? _openStore;
        public RelayCommand OpenView
        {
            get
            {
                return _openStore! ??
                    (_openStore = new RelayCommand(obj =>
                    {
                        string? str = obj as string;
                        switch (str)
                        {
                            case "store":
                                {
                                    LocatorControl.viewPage.CurrentView.Content = new StoreView();
                                    //OnPropertyChanged("CurrentView");
                                    break;
                                }
                            case "cart":
                                {
                                    LocatorControl.viewPage.CurrentView.Content = new StartView();
                                    break;
                                }
                            case "exit":
                                {
                                    
                                    break;
                                }
                            default:
                                {
                                    LocatorControl.viewPage.CurrentView.Content = new StartView();
                                    break;
                                }
                        }
                    }
                    ));
            }
        }
    }
}
