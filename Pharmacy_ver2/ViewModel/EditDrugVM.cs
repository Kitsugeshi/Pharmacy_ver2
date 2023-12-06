using Pharmacy_ver2.DataContext;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_ver2.ViewModel
{
    class EditDrugVM : PChanged
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string? IsPre { get; set; }
        public string? Syms { get; set; }

        public EditDrugVM(Drug chosenD) 
        { 
            ChosenD = chosenD;
            Name = chosenD.Name;
            Count = chosenD.Count;
            Cost = chosenD.Cost;
            IsPre = chosenD.IsPrescription;
            Syms = chosenD.Symptoms;
        }

        private Drug? _chosenD;
        public Drug? ChosenD
        {
            get => _chosenD!;
            set { _chosenD = value; OnPropertyChanged(nameof(ChosenD)); }
        }

        RelayCommand? _confirm;
        public RelayCommand Confirm
        {
            get
            {
                return _confirm! ??
                   (_confirm = new RelayCommand(obj =>
                   {
                       ChosenD!.Name = Name!;
                       ChosenD!.Count = Count!;
                       ChosenD!.Cost = Cost!;
                       ChosenD!.IsPrescription = IsPre!;
                       ChosenD!.Symptoms = Syms!;
                       Application.Current.Windows[2].Close();
                   }
                   ));
            }
        }

        RelayCommand? _cancel;
        public RelayCommand Cancel
        {
            get
            {
                return _cancel! ??
                   (_cancel = new RelayCommand(obj =>
                   {
                       Application.Current.Windows[2].Close();
                   }
                   ));
            }
        }
    }
}
