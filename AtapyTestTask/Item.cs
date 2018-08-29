using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtapyTestTask
{
    abstract public class Item
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Barcode { get; set; }

        public virtual void PrintProperties(int level = 0)
        {
            var tabs = new String('\t', level);
            Console.Out.WriteLine(tabs + "Название: " + Name);
            Console.Out.WriteLine(tabs + "Цена: " + Price + " у.е.");
            Console.Out.WriteLine(tabs + "Штрихкод: " + Barcode);
        }
    }
}