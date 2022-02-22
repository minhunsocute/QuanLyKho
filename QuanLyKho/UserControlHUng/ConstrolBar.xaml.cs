using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuanLyKho.ViewModel;

namespace QuanLyKho.UserControlHUng
{
    /// <summary>
    /// Interaction logic for ConstrolBar.xaml
    /// </summary>
    public partial class ConstrolBar : UserControl
    {
        public ConstrolBarBm ViewModel { get; set; }
        public ConstrolBar()
        {
            InitializeComponent();
            this.DataContext = ViewModel = new ConstrolBarBm();
        }
    }
}
