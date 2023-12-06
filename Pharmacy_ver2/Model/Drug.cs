using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pharmacy_ver2
{
    public class Drug : PChanged
    {
        private string? _name;
        private int _cost;
        private int _count;
        private string? _isPrescription;
        private string? _symptomList;

        public string Name
        {
            get { return _name!; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; OnPropertyChanged(nameof(Count)); }
        }
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; OnPropertyChanged(nameof(Cost)); }
        }
        public string IsPrescription
        {
            get { return _isPrescription!; }
            set { _isPrescription = value; OnPropertyChanged(nameof(IsPrescription)); }
        }
        public string Symptoms
        {
            get { return _symptomList!; }
            set { _symptomList = value; OnPropertyChanged(nameof(Symptoms)); }
        }

        public Drug(string name, int count, int cost, string isPre, string symptoms)
        {
            Name = name;
            Count = count;
            Cost = cost;
            IsPrescription = isPre;
            Symptoms = symptoms;
        }
    }
}
