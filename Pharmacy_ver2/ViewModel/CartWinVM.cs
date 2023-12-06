﻿using Pharmacy_ver2.DataContext;
using Pharmacy_ver2.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Pharmacy_ver2
{
    class CartWinVM : PChanged
    {
        private ObservableCollection<Drug>? drugList = LocatorControl.dataDrug.CartDrugList;
        public ObservableCollection<Drug> DrugList
        {
            get => drugList!;
            set { drugList = value; OnPropertyChanged(nameof(DrugList)); }
        }
        private Drug? chosenD;
        public Drug ChosenD
        {
            get => chosenD!;
            set { chosenD = value; OnPropertyChanged(nameof(ChosenD)); }
        }

        private string? _cost = LocatorControl.dataDrug.FullCost;
        public string Cost
        {
            get => _cost!;
            set { _cost = value; OnPropertyChanged(nameof(Cost)); }
        }

        RelayCommand? _back;
        public RelayCommand Back
        {
            get
            {
                return _back! ??
                    (_back = new RelayCommand(obj =>
                    {
                        LocatorControl.viewPage.CurrentView.Content = new StartView();
                    }
                    ));
            }
        }
    }
}
