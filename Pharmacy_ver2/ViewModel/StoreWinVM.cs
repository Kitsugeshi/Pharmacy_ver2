using Pharmacy;
using Pharmacy.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Pharmacy.ViewModel
{
    class StoreWinVM : PChanged
    {
        private ObservableCollection<Drug>? _drugList;
        public ObservableCollection<Drug> DrugList
        {
            get { return _drugList!; }
            set { _drugList = value; OnPropertyChanged(nameof(DrugList)); }
        }

        private Drug chosenD;
        public Drug ChosenD
        {
            get => chosenD;
            set { chosenD = value; OnPropertyChanged(nameof(ChosenD)); }
        }

        private ObservableCollection<string> _symptoms = new ObservableCollection<string>();
        public ObservableCollection<string> Symptoms
        {
            get => _symptoms;
            set { _symptoms = value; OnPropertyChanged(nameof(Symptoms)); }
        }

        private ObservableCollection<Drug> _sortedList = new ObservableCollection<Drug>();
        public ObservableCollection<Drug> SortedList
        {
            get => _sortedList;
            set { _sortedList = value; OnPropertyChanged(nameof(SortedList)); }
        }
        public StoreWinVM()
        {
            DrugList = new ObservableCollection<Drug>
            {
                new Drug("МедоЛеч", 10, "Нет", "головная боль, насморк"),
                new Drug("КардиоКлин", 25, "Да", "боли в области сердца, головокружение"),
                new Drug("ИммуноГард", 15, "Нет", "ослабленный иммунитет, простуда"),
                new Drug("АнтиГрипекс", 12, "Нет", "нервное напряжение, бессонница"),
                new Drug("СпокоПрин", 30, "Да", "грипп, высокая температура"),
                new Drug("ЛегкоДыш", 18, "Нет", "затрудненное дыхание, кашель"),
                new Drug("АнтиАллерг", 22, "Нет", "аллергия, зуд"),
                new Drug("ПроБиотик", 28, "Нет", "нарушение микрофлоры, желудочные боли"),
                new Drug("ГемоСтоп", 35, "Да", "кровотечение, анемия"),
                new Drug("АнтиРевм", 40, "Да", "ревматизм"),
                new Drug("Вита-Энергия", 15, "Нет", "общая слабость, усталость"),
                new Drug("ОстеоФлекс", 32, "Да", "заболевания костей, заболевания суставов"),
                new Drug("ГастроКомфорт", 20, "Нет", "гастрит, изжога"),
                new Drug("Лекарь", 25, "Нет", "лихорадка, слабость"),
                new Drug("СпасиБол", 38, "Да", "сильные боли, воспаление")
            };

            SortedList = DrugList;
        }

        RelayCommand? _back;
        public RelayCommand Back
        {
            get
            {
                return _back! ??
                    (_back = new RelayCommand(obj =>
                    {

                    }
                    ));
            }
        }

        RelayCommand? _openCart;
        public RelayCommand OpenCart
        {
            get
            {
                return _openCart! ??
                    (_openCart = new RelayCommand(obj =>
                    {
                        CartWin cartWin = new CartWin();
                        if (cartWin.ShowDialog() == true)
                        {
                            
                        }
                    }
                    ));
            }
        }

        private string _text = "";
        public string Text 
        { 
            get => _text; 
            set { _text = value; OnPropertyChanged(nameof(Text)); }
        }

        private RelayCommand? _search;
        public RelayCommand Search
        {
            get
            {
                return _search! ??
                    (_search = new RelayCommand(obj =>
                    {
                        if (Text.Length != 0)
                        {
                            string key = Text.ToLower();
                            ObservableCollection<Drug> List = new ObservableCollection<Drug>();
                            for (int i = 0; i < DrugList.Count; i++)
                            {
                                if (DrugList[i].Name.ToLower().Contains(key) || DrugList[i].Symptoms.Contains(key))
                                {
                                    List.Add(DrugList[i]);
                                }
                            }
                            SortedList = List;
                        }
                        else SortedList = DrugList;
                    }
                    ));
            }
        }
    }
}
