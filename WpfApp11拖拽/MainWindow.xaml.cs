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

namespace WpfApp11拖拽
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public TransformGroup transGroup;
        public MainWindow()
        {
            InitializeComponent();           
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //transGroup.Children.Add(new ScaleTransform());
            //transGroup.Children.Add(new TranslateTransform());
            //ImgCtl.RenderTransform = transGroup;
        }
        private void ContentControl_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            Control ctl = sender as Control;
            System.Windows.Point point = e.GetPosition(ctl);
            //滚轮滚动时控制 放大的倍数,没有固定的值，可以根据需要修改。
            double scale = e.Delta * 0.002;

            ZoomImage(transGroup, point, scale);
        }


        //对控件进行缩放。
        private void ZoomImage(TransformGroup group, Point point, double scale)
        {
            Point pointToContent = group.Inverse.Transform(point);

            ScaleTransform scaleT = group.Children[0] as ScaleTransform;

            if (scaleT.ScaleX + scale < 1) return;

            scaleT.ScaleX += scale;

            scaleT.ScaleY += scale;

            TranslateTransform translateT = group.Children[1] as TranslateTransform;

            translateT.X = -1 * ((pointToContent.X * scaleT.ScaleX) - point.X);

            translateT.Y = -1 * ((pointToContent.Y * scaleT.ScaleY) - point.Y);

        }

        //用于保存鼠标点击时的位置
        System.Windows.Point mousePosition = new System.Windows.Point();
        //鼠标点击时控件位置
        System.Windows.Point contentCtlPosition = new System.Windows.Point();


        private void ContentControl_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Control ctl = sender as Control;
            mousePosition = e.GetPosition(ctl);
            TranslateTransform tt = transGroup.Children[1] as TranslateTransform;

            contentCtlPosition = new Point(tt.X, tt.Y);
        }
        private void MasterScrollViewer_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Control ctl = sender as Control;
                Point desPosition = e.GetPosition(ctl);

                TranslateTransform transform = transGroup.Children[1] as TranslateTransform;
                //控件移动位置的计算方式为：鼠标点击时位置+拖拽的长度(当前坐标-鼠标点击时的坐标).
                transform.X = contentCtlPosition.X + (desPosition.X - mousePosition.X);
                transform.Y = contentCtlPosition.Y + (desPosition.Y - mousePosition.Y);

            }
        }

      
    }
}
