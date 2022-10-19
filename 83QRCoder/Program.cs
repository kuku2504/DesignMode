using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;
using System.Drawing;
namespace _83QRCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string qrcodeFilePath = CreateCode_Simple("http://www.baidu.com");
            Console.WriteLine(qrcodeFilePath);
            Console.ReadKey();
        }
        public static string CreateCode_Simple(string text)
        {
            //获取目录
            string dirFile = Path.GetFullPath("../..");

            string newFileName = Guid.NewGuid().ToString("N") + ".png";
            string newFilePath = string.Format("{0}\\QrcodeFiles\\{1}", dirFile, newFileName);

            if (!System.IO.Directory.Exists(dirFile))
            {
                System.IO.Directory.CreateDirectory(dirFile);
            }
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            //二维码密度
            qrCodeEncoder.QRCodeScale = 8;
            qrCodeEncoder.QRCodeVersion = 0;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            System.Drawing.Image image = qrCodeEncoder.Encode(text);

            System.IO.FileStream fs = new System.IO.FileStream(newFilePath, System.IO.FileMode.OpenOrCreate,
                System.IO.FileAccess.Write);
            image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);

            fs.Close();
            image.Dispose();

            return newFilePath;
        }
    }
    
}
