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

        public virtual void PrintProperties()
        {
            Console.Out.WriteLine("Название: {0}", Name);
            Console.Out.WriteLine("Цена: {0} у.е.", Price);
            Console.Out.WriteLine("Штрихкод: {0}", Barcode);
        }
    }
}