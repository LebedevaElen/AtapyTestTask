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
            Console.WriteLine("Название: {0}", Name);
            Console.WriteLine("Цена: {0} у.е.", Price);
            Console.WriteLine("Штрихкод: {0}", Barcode);
        }
    }

    abstract public class Book : Item
    {
        public int PageCount { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.WriteLine("Количество страниц: {0}", PageCount);
        }
    }

    public class ProgrammingBook : Book
    {
        public string ProgLanguage { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.WriteLine("Язык программирования: {0}", ProgLanguage);
        }
    }

    public class CookingBook : Book
    {
        public string MainIngredient { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.WriteLine("Основной ингредиент: {0}", MainIngredient);
        }
    }

    public class EsotericsBook : Book
    {
        public int MinAge { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.WriteLine("Минимальный возраст читателя: {0}", MinAge);
        }
    }

    abstract public class Disk : Item
    {
        public DiskContent Content { get; set; }
    }

    public class CD : Disk { }

    public class DVD : Disk { }
}
