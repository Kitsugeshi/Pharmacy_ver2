using Pharmacy_ver2.DataContext;
using Pharmacy_ver2.View;
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

namespace Pharmacy_ver2.ViewModel
{
    class StoreWinVM : PChanged
    {
        private ObservableCollection<Drug>? _drugList;
        public ObservableCollection<Drug> DrugList
        {
            get { return _drugList!; }
            set { _drugList = value; OnPropertyChanged(nameof(DrugList)); }
        }

        private Drug? chosenD;
        public Drug ChosenD
        {
            get => chosenD!;
            set { chosenD = value; OnPropertyChanged(nameof(ChosenD)); }
        }

        private ObservableCollection<Drug>? _cartList;
        public ObservableCollection<Drug> CartList
        {
            get { return _cartList!; }
            set { _cartList = value; OnPropertyChanged(nameof(DrugList)); }
        }

        private ObservableCollection<Drug> _sortedList = new ObservableCollection<Drug>();
        public ObservableCollection<Drug> SortedList
        {
            get => _sortedList;
            set { _sortedList = value; OnPropertyChanged(nameof(SortedList)); }
        }
        public StoreWinVM()
        {
            DrugList = LocatorControl.dataDrug.DrugList;
            SortedList = DrugList;
            CartList = LocatorControl.dataDrug.CartDrugList;
        }

        RelayCommand? _back;
        public RelayCommand Back
        {
            get
            {
                return _back! ??
                    (_back = new RelayCommand(obj =>
                    {
                        LocatorControl.viewPage.CurrentView.Content = new StartView();
                    }
                    ));
            }
        }

        RelayCommand? _addToCart;
        public RelayCommand AddToCart
        {
            get
            {
                return _addToCart! ??
                    (_addToCart = new RelayCommand(obj =>
                    {
                        int cost = 0;
                        bool flag = true;
                        LocatorControl.dataDrug.FullCost = "";
                        if (CartList.Count != 0)
                        {
                            foreach (var drug in CartList)
                            {
                                if (drug.Name == ChosenD.Name)
                                {
                                    drug.Count++;
                                    flag = false;
                                }
                            }
                            if (flag)
                            {
                                CartList.Add(new Drug(ChosenD));
                                CartList.Last().Count = 1;
                            }       
                        }
                        else
                        {
                            CartList.Add(new Drug(ChosenD));
                            CartList[0].Count = 1;
                        }
                        foreach (var drug in CartList)
                        {
                            if (drug.Count == 1)  
                                cost += drug.Cost;
                            else
                            {
                                cost += drug.Cost * drug.Count;
                            }
                        }
                        LocatorControl.dataDrug.FullCost = cost.ToString() + " долларов";
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
