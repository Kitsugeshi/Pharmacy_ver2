using Pharmacy_ver2.DataContext;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_ver2.View;

namespace Pharmacy_ver2.ViewModel
{
    class NewDrugVM : PChanged
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string? IsPre { get; set; }
        public string? Syms { get; set; }

        RelayCommand? _add;
        public RelayCommand Add {
            get
            {
                return _add! ??
                   (_add = new RelayCommand(obj =>
                   {
                       LocatorControl.dataDrug.DrugList.Add(new Drug(Name!, Count, Cost, IsPre!, Syms!));
                       Application.Current.Windows[1].Close();
                   }
                   ));
            }   
        }

    }
}
