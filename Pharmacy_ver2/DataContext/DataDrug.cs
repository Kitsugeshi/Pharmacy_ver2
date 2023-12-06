using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_ver2.DataContext
{
    public class DataDrug : PChanged
    {
        public ObservableCollection<Drug> DrugList = new ObservableCollection<Drug>
        {
                new Drug("МедоЛеч", 35, 10, "Нет", "головная боль, насморк"),
                new Drug("КардиоКлин", 47, 25, "Да", "боли в области сердца, головокружение"),
                new Drug("ИммуноГард", 38, 15, "Нет", "ослабленный иммунитет, простуда"),
                new Drug("АнтиГрипекс", 9, 12, "Нет", "нервное напряжение, бессонница"),
                new Drug("СпокоПрин", 23, 30, "Да", "грипп, высокая температура"),
                new Drug("ЛегкоДыш", 45, 18, "Нет", "затрудненное дыхание, кашель"),
                new Drug("АнтиАллерг", 15, 22, "Нет", "аллергия, зуд"),
                new Drug("ПроБиотик", 6, 28, "Нет", "нарушение микрофлоры, желудочные боли"),
                new Drug("ГемоСтоп", 20, 35, "Да", "кровотечение, анемия"),
                new Drug("АнтиРевм", 5, 40, "Да", "ревматизм"),
                new Drug("Вита-Энергия", 35, 15, "Нет", "общая слабость, усталость"),
                new Drug("ОстеоФлекс", 23, 32, "Да", "заболевания костей, заболевания суставов"),
                new Drug("ГастроКомфорт", 26, 20, "Нет", "гастрит, изжога"),
                new Drug("Лекарь", 17, 25, "Нет", "лихорадка, слабость"),
                new Drug("СпасиБол", 19, 38, "Да", "сильные боли, воспаление")
        };

        public ObservableCollection<Drug> CartDrugList = new ObservableCollection<Drug>();
        public string FullCost = "0 долларов";
    }
}
