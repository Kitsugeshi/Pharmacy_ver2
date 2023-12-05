using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class CartWinVM : PChanged
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

        private string _fullCost;
        public string FullCost 
        { 
            get => _fullCost;
            set { _fullCost = value; OnPropertyChanged(nameof(FullCost)); }
        }

        public CartWinVM() 
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

            int cost = 0;
            foreach (var drug in DrugList)
            {
                cost += drug.Cost;
            }
            FullCost = cost.ToString() + " долларов";
        }

        
    }
}
