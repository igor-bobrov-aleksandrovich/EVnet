using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace EVnet.Model
{
    public class Notice
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public virtual List<User> Users { get; set; }
        public Notice()
        {
            ID = 0;
            Name = "";
            Image = new byte[0];
            Users = new List<User>();
        }
        public Notice(int id, string name, decimal price, string imagePath)
        {
            ID = 0;
            Name = "";
            BitmapImage image = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            //Image = DataTransform.JpgToByte(image);
            Users = new List<User>();
        }
    }
}
