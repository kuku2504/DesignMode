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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //btn.MouseLeftButtonDown += btn_MouseLeftButtonDown;
            //btn.MouseMove += btn_MouseMove;
            //btn.MouseLeftButtonUp += btn_MouseLeftButtonUp;
        }

        Point pos = new Point();
        void btn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button tmp = (Button)sender;
            pos = e.GetPosition(null);
            tmp.CaptureMouse();
            tmp.Cursor = Cursors.Hand;
        }
        void btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Button tmp = (Button)sender;
                double dx = e.GetPosition(null).X - pos.X + tmp.Margin.Left;
                double dy = e.GetPosition(null).Y - pos.Y + tmp.Margin.Top;
                tmp.Margin = new Thickness(dx, dy, 0, 0);
                pos = e.GetPosition(null);
            }
        }
        void btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Button tmp = (Button)sender;
            tmp.ReleaseMouseCapture();
        }
    }
}
