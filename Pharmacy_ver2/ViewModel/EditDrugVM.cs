using Pharmacy_ver2.DataContext;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace Pharmacy_ver2.ViewModel
{
    class EditDrugVM : PChanged
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string? IsPre { get; set; }
        public string? Syms { get; set; }
        public string? Usage { get; set; }
        public string? SideEffects { get; set; }
        public string? Contra { get; set; }

        private Drug? _chosenD;
        public Drug? ChosenD
        {
            get => _chosenD!;
            set { _chosenD = value; OnPropertyChanged(nameof(ChosenD)); }
        }
        public EditDrugVM(Drug chosenD) 
        { 
            ChosenD = chosenD;
            Image = chosenD.Image;
            Name = chosenD.Name;
            Description = chosenD.Description;
            Count = chosenD.Count;
            Cost = chosenD.Cost;
            IsPre = chosenD.IsPrescription;
            Syms = chosenD.Symptoms;
            Usage = chosenD.UsageInstruction;
            SideEffects = chosenD.SideEffects;
            Contra = chosenD.Contraindications;
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

        RelayCommand? _confirm;
        public RelayCommand Confirm
        {
            get
            {
                return _confirm! ??
                   (_confirm = new RelayCommand(obj =>
                   {
                       ChosenD!.Image = Image!;
                       ChosenD!.Name = Name!;
                       ChosenD!.Description = Description!;
                       ChosenD!.Count = Count!;
                       ChosenD!.Cost = Cost!;
                       ChosenD!.IsPrescription = IsPre!;
                       ChosenD!.Symptoms = Syms!;
                       ChosenD!.UsageInstruction = Usage!;
                       ChosenD!.SideEffects = SideEffects!;
                       ChosenD!.Contraindications = Contra!;
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
