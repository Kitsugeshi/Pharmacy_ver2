using Pharmacy_ver2.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Pharmacy_ver2.ViewModel
{
    class MDVM : PChanged
    {
        public Image Img { get; set; } = new Image();   
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; }
        public int Cost { get; set; }
        public string? IsPre { get; set; }
        public string? Syms { get; set; }
        public string? Usage { get; set; }
        public string? SideEffects { get; set; }
        public string? Contra { get; set; }

        public MDVM(Drug chosenD, Image i)
        {
            if (chosenD.Image.Length > 30)
                i.Source = new BitmapImage(new Uri(chosenD.Image, UriKind.Absolute));
            else i.Source = new BitmapImage(new Uri(chosenD.Image, UriKind.Relative));
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

        RelayCommand? _exit;
        public RelayCommand Exit
        {
            get
            {
                return _exit! ??
                   (_exit = new RelayCommand(obj =>
                   {
                       Application.Current.Windows[2].Close();
                   }
                   ));
            }
        }
    }
}
