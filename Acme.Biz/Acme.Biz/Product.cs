using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class Product
    {
        #region Array best practices
/// <summary>
/// No considerar el uso de matrices cuando el tamaño
/// requerido de una lista se puede determinar en tiempo de diseño
/// </summary>
        public Product()
        {
            var colorOptions = new string[4];
            colorOptions[0] = "Red";
            colorOptions[1] = "Expresso";
            colorOptions[2] = "White";
            colorOptions[3] = "Navy";

            Console.WriteLine(colorOptions);

            //Collection initializers
            string[] colorOptions2 = new string[4] { "Red", "Espresso", "White", "Navy" };
            foreach (var item in colorOptions2)
            {
                Console.WriteLine($"The color is {item}");
            }
        }
        #endregion

    }
}
