using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Model
{
    public class Image
    {
        public int ImageID { get; set; }
        public byte[] ImageData { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
