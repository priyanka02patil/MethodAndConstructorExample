using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectProgram
{
    public class Product
    {
        private int productcode;
        private String productname;
        private double productprice, discountprice;

        public Product(int pcode, string pname, double pprice)
        {
            productcode = pcode;
            productname = pname;
            productprice = pprice;
        }

        public void CalculateDiscount()
        {
            if(productprice > 1000)
            {
                discountprice = productprice * 0.1;
            }
        }

        public string Show()
        {
            return $" Discounted price is = {discountprice}";
        }
    }
}
