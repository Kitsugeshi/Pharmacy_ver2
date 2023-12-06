﻿using System;
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
                new Drug("../Assets/1.png","Аспирин", "Анальгетик и жаропонижающее средство, содержащее ацетилсалициловую кислоту.", 35, 10, "Да", "Боль, жар, воспаление.", "Принимать после еды. Дозировка зависит от возраста и состояния здоровья. Не рекомендуется на голодный желудок", "Возможны желудочные боли, изжога. При длительном применении - риск кровотечений.", "Язвенная болезнь желудка, аллергия на ацетилсалициловую кислоту."),
                new Drug("../Assets/2.png","Парацетамол", "Анальгетик и жаропонижающее средство.", 47, 25, "Нет", "Боль, жар.", "Принимать натощак или после еды. Дозировка зависит от возраста и веса.", "Редко вызывает побочные эффекты при правильном применении.", "По индивидуальной непереносимости."),
                new Drug("../Assets/3.png","Ибупрофен", "Противовоспалительное и болеутоляющее средство.", 38, 15, "Да", "Боль, воспаление.", "Принимать после еды. Дозировка зависит от возраста и веса.", "Возможны желудочные боли, изжога. При длительном применении - риск повреждения слизистой оболочки желудка.", "Язвенная болезнь желудка, аллергия на ибупрофен, беременность (в определенных случаях)."),
                new Drug("../Assets/4.png","Декспантенол", "Препарат для лечения и профилактики заболеваний слизистой оболочки рта и горла.", 9, 12, "Нет", "Сухость, раздражение.", "Применять в виде спрея или раствора. Для полоскания горла и увлажнения слизистой оболочки.", "Редко вызывает побочные эффекты при правильном применении.", "По индивидуальной непереносимости."),
                new Drug("../Assets/5.png","Фенистил", "Препарат для снятия зуда, предотвращения и лечения аллергических реакций.", 23, 30, "Да", "Зуд, аллергическая реакция.", "Принимать внутрь или наносить на кожу в виде геля. Дозировка зависит от возраста.", "Сонливость, снижение концентрации внимания.", "Глаукома, астма, беременность (в определенных случаях)."),
                new Drug("../Assets/6.png","Цетрин", "Антигистаминное средство для лечения аллергий.", 45, 18, "Нет", "Аллергические проявления.", "Принимать внутрь. Дозировка зависит от возраста.", "Сухость во рту, сонливость (в редких случаях).", "Беременность, период грудного вскармливания, аллергия на компоненты препарата."),
                new Drug("../Assets/7.png","Нурофен", "Противовоспалительное и жаропонижающее средство на основе ибупрофена.", 15, 22, "Да", "Боль, воспаление.", "Принимать после еды. Дозировка зависит от возраста и веса.", "Возможны желудочные боли, изжога. При длительном применении - риск повреждения слизистой оболочки желудка.", "Язвенная болезнь желудка, аллергия на ибупрофен, "),
                new Drug("../Assets/8.png","Левомицетин", "Антимикробный препарат для лечения инфекций.", 6, 28, "Нет", "Инфекционные проявления.", "Принимать внутрь. Дозировка зависит от характера инфекции.", "Возможны нарушения кроветворения (в редких случаях).", "Беременность, период грудного вскармливания, аллергия на компоненты препарата."),
                new Drug("../Assets/9.png","Линекс", "Пробиотик для восстановления микрофлоры кишечника.", 20, 35, "Нет", "Расстройства ЖКТ.", "Принимать внутрь, желательно после еды. Дозировка зависит от возраста.", "Редко вызывает побочные эффекты при правильном применении.", "Индивидуальная непереносимость компонентов."),
                new Drug("../Assets/10.png","Эспумизан", "Препарат для снятия избыточных газов в желудке и кишечнике.", 5, 40, "Нет", "Вздутие, избыточные газы.", "Принимать внутрь после еды. Дозировка зависит от возраста.", "Редко вызывает побочные эффекты при правильном применении.", "Индивидуальная непереносимость компонентов.")
        };

        public ObservableCollection<Drug> CartDrugList = new ObservableCollection<Drug>();
        public string FullCost = "0 долларов";
    }
}
