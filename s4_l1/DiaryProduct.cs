using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4_l1
{
    public class DiaryProduct: Product
    {
        //DateTime date0, date1;
        public List<DateTime> date = new(2);

        public DiaryProduct(string name, decimal vendorCode, decimal price, DateTime date0, DateTime date1)
            : base(name, vendorCode, price)
        {
            date.Add(date0);
            date.Add(date1);
        }
    }
}
