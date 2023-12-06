using Pharmacy_ver2.DataContext;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_ver2.View;
using System.Windows.Controls;
using Microsoft.Win32;

namespace Pharmacy_ver2.ViewModel
{
    class NewDrugVM : PChanged
    {
        private string? image = "";
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string? IsPre { get; set; }
        public string? Syms { get; set; }
        public string? Usage { get; set; }
        public string? SideEffects { get; set; }
        public string? Contra { get; set; }
        public string? Image
        {
            get => image!;
            set { image = value; OnPropertyChanged(nameof(Image)); }
        }

        private RelayCommand? _load;
        public RelayCommand Load
        {
            get
            {
                return _load! ??
                    (_load = new RelayCommand(obj =>
                    {
                        OpenFileDialog op = new OpenFileDialog();
                        op.Title = "Select a pic";
                        op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                            "Portable Network Graphic (*.png)|*.png";
                        if (op.ShowDialog() == true)
                        {
                            Image = op.FileName;
                        }
                    }
                    ));
            }
        }

        RelayCommand? _add;
        public RelayCommand Add {
            get
            {
                return _add! ??
                   (_add = new RelayCommand(obj =>
                   {
                       LocatorControl.dataDrug.DrugList.Add(new Drug(Image!, Name!, Description!, Count, Cost, IsPre!, Syms!, Usage!, SideEffects!, Contra!));
                       Application.Current.Windows[2].Close();
                   }
                   ));
            }   
        }
    }
}
