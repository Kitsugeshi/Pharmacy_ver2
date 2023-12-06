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
        private string? _image;
        private string? _name;
        private string? _description;
        private int _cost;
        private int _count;
        private string? _isPrescription;
        private string? _symptomList;
        private string? _usageInstruction;
        private string? _sideEffects;
        private string? _contraindications;

        public string Image
        {
            get { return _image!; }
            set { _image = value; OnPropertyChanged(nameof(Image)); }
        }
        public string Name
        {
            get { return _name!; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public string Description
        {
            get { return _description!; }
            set { _description = value; OnPropertyChanged(nameof(Description)); }
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
        public string Contraindications
        {
            get { return _contraindications!; }
            set { _contraindications = value; OnPropertyChanged(nameof(Contraindications)); }
        }
        public string SideEffects
        {
            get { return _sideEffects!; }
            set { _sideEffects = value; OnPropertyChanged(nameof(SideEffects)); }
        }
        public string UsageInstruction
        {
            get { return _usageInstruction!; }
            set { _usageInstruction = value; OnPropertyChanged(nameof(UsageInstruction)); }
        }
        

        public Drug(string img, string name, string description, int count, int cost, string isPre, string symptoms, string usageInst, string sideEffects, string con)
        {
            Image = img;
            Name = name;
            Description = description;
            Count = count;
            Cost = cost;
            IsPrescription = isPre;
            Symptoms = symptoms;
            UsageInstruction = usageInst;
            SideEffects = sideEffects;
            Contraindications = con;
        }

        public Drug(Drug obj)
        {
            Image = obj.Image;
            Name = obj.Name;
            Description = obj.Description;
            Count = obj.Count;
            Cost = obj.Cost;
            IsPrescription = obj.IsPrescription;
            Symptoms = obj.Symptoms;
            UsageInstruction = obj.UsageInstruction;
            SideEffects = obj.SideEffects;
            Contraindications = obj.Contraindications;
        }
    }
}
