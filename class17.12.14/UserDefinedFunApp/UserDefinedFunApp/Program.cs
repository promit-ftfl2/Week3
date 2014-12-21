using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedFunApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1=new Item();
            item1.name = "khata";
            item1.unitprice = 50;
            Console.WriteLine(item1.name);
            Console.WriteLine(item1.unitprice.ToString());
            Console.ReadKey();
        }
    }
}
