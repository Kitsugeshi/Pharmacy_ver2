using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_ver2.ViewModel
{
    class MDVM : PChanged
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string? IsPre { get; set; }
        public string? Syms { get; set; }
        public MDVM(Drug chosenD) 
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
    }
}
