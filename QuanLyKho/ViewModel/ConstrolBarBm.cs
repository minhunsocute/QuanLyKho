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
    public class ConstrolBarBm:BaseViewModel    
    {
        #region commands
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MaxWindowCommand { get; set; }
        public ICommand MinWindowCommand { get; set; }
        #endregion
        public ConstrolBarBm()
        {
            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.Close();  
                }
            }
            );
            MaxWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if(w != null)
                {
                    if (w.WindowState == WindowState.Maximized)
                        w.WindowState = WindowState.Normal;
                    else
                        w.WindowState = WindowState.Maximized;
                }
            });
            MinWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
               {
                   FrameworkElement window = GetWindowParent(p);
                   var w = window as Window;
                   if (w != null)
                       w.WindowState = WindowState.Minimized;
               });
        }
        FrameworkElement GetWindowParent(UserControl p)
        {
            return Window.GetWindow(p);
        }
    }
}
