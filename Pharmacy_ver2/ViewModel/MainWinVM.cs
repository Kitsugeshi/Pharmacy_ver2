using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Pharmacy_ver2.DataContext;
using Pharmacy_ver2.View;

namespace Pharmacy_ver2.ViewModel
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
                                    break;
                                }
                            case "cart":
                                {
                                    LocatorControl.viewPage.CurrentView.Content = new CartView();
                                    break;
                                }
                            case "exit":
                                {
                                    Application.Current.Shutdown();
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
