using Pharmacy_ver2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Pharmacy_ver2.DataContext
{
    public class ViewPage: PChanged
    {
        private UserControl _currentView = new StartView();
        public UserControl CurrentView
        {
            get
            {
                if (_currentView == null)
                {
                    return new StartView();
                }
                return _currentView;
            }
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        private UserControl _previousView = new StartView();
        public UserControl PreviousView
        {
            get
            {
                return _previousView;
            }
            set
            {
                _previousView = value;
                OnPropertyChanged(nameof(PreviousView));
            }
        }
    }
}
