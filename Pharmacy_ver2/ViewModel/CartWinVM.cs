using Pharmacy_ver2.DataContext;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pharmacy
{
    class CartWinVM : PChanged
    {
        private Drug chosenD;
        public Drug ChosenD
        {
            get => chosenD;
            set { chosenD = value; OnPropertyChanged(nameof(ChosenD)); }
        }

        private string _fullCost;
        public string FullCost 
        { 
            get => _fullCost;
            set { _fullCost = value; OnPropertyChanged(nameof(FullCost)); }
        }

        public CartWinVM() 
        { 
            int cost = 0;
            foreach (var drug in LocatorControl.dataDrug.DrugList)
            {
                cost += drug.Cost;
            }
            FullCost = cost.ToString() + " долларов";
        }

        
    }
}
