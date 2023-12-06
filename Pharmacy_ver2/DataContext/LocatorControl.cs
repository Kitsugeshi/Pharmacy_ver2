using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_ver2.DataContext
{
    public static class LocatorControl
    {
        public static DataDrug dataDrug { get; set; } = new DataDrug();

        private static ViewPage? _viewPage;
        public static ViewPage viewPage
        {
            get
            {
                if(_viewPage == null)
                {
                    _viewPage = new ViewPage();
                }
                return _viewPage;
            }
            set
            {
                _viewPage = value;
            }
        }
    }
}
