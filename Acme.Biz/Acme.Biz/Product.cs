using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class Product
    {
        public Product()
        {
            var colorOptions = new string[4];
            colorOptions[0] = "Red";
            colorOptions[1] = "Expresso";
            colorOptions[2] = "White";
            colorOptions[3] = "Navy";
            Console.WriteLine(colorOptions);
        }
    }
}
