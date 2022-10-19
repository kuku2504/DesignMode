using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82QRCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Drawing.Image image = code("http://weixin.qq.com/r/qzj377TEKulVrfCM9225", 5, 10, "C:\\Users\\Pride\\Pictures\\myimage\\1.jpg", 15, 1, true);
            string filename = Guid.NewGuid() + ".jpg";
            string filepath = filename;
            System.IO.FileStream fs = new System.IO.FileStream(filepath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write);
            image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            fs.Close();
            image.Dispose();
            Console.WriteLine("OK");
            Console.Read();
        }
    }
    public class QRCodeHelper
    {
        //todo 1.保存为二维码
        //2.上传七牛云

        public static QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();

        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="link">生成的内容</param>
        /// <returns></returns>
        public static async Task<string> GetQRCode(string link)
        {
            string guid = Guid.NewGuid().ToString().Replace("-", "") + ".png";    //图片名称
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(link, QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrcode.GetGraphic(5, System.Drawing.Color.Black, System.Drawing.Color.White, null, 15, 3);
            string filePath = Path.Combine("qrcodetest", guid); //图片保存地址
            //获取文件对象
            FileInfo file = new FileInfo(filePath);
            //判断文件夹是否创建
            if (!file.Directory.Exists) { file.Directory.Create(); }
            qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            return filePath;

            /* GetGraphic方法参数说明
                 public Bitmap GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor, Bitmap icon = null, int iconSizePercent = 15, int iconBorderWidth = 6, bool drawQuietZones = true)
                 int pixelsPerModule:生成二维码图片的像素大小 ，我这里设置的是5
                 Color darkColor：暗色   一般设置为Color.Black 黑色
                 Color lightColor:亮色   一般设置为Color.White  白色
                 Bitmap icon :二维码 水印图标 例如：Bitmap icon = new Bitmap(context.Server.MapPath("~/images/zs.png")); 默认为NULL ，加上这个二维码中间会显示一个图标
                 int iconSizePercent： 水印图标的大小比例 ，可根据自己的喜好设置
                 int iconBorderWidth： 水印图标的边框
                 bool drawQuietZones:静止区，位于二维码某一边的空白边界,用来阻止读者获取与正在浏览的二维码无关的信息 即是否绘画二维码的空白边框区域 默认为true
           */
        }
    }
}
