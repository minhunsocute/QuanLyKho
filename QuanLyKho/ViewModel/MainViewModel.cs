using QuanLyKho.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    
    public class MainViewModel: BaseViewModel
    {
        #region Command
        public ICommand UnitCommand { get; set; }
        public ICommand SupliderCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        #endregion
        public MainViewModel()
        {
            UnitCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                UnitWindow uw = new UnitWindow();
                uw.ShowDialog();
            });
            SupliderCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                SupliderWindow sw = new SupliderWindow();
                sw.ShowDialog();
            });
            CustomerCommand = new RelayCommand<Object>((p) => { return true; }, (p) =>
            {
                CustomerWindow cw = new CustomerWindow();
                cw.ShowDialog();
            });
        }
    }
}
