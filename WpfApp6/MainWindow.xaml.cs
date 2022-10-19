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

namespace WpfApp6
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnTestPopup2_Click(object sender, RoutedEventArgs e)
        {
            pop2.IsOpen = true;
        }
        private void btnOK2_Click(object sender, RoutedEventArgs e)
        {
            pop2.IsOpen = false;
        }
        private void btnCancel2_Click(object sender, RoutedEventArgs e)
        {
            pop2.IsOpen = false;
        }
    }
}
