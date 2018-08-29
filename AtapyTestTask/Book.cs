using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtapyTestTask
{
    abstract public class Book : Item
    {
        public int PageCount { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.Out.WriteLine("Количество страниц: {0}", PageCount);
        }
    }

    public class ProgrammingBook : Book
    {
        public string ProgLanguage { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.Out.WriteLine("Язык программирования: {0}", ProgLanguage);
        }
    }

    public class CookingBook : Book
    {
        public string MainIngredient { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.Out.WriteLine("Основной ингредиент: {0}", MainIngredient);
        }
    }

    public class EsotericsBook : Book
    {
        public int MinAge { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.Out.WriteLine("Минимальный возраст читателя: {0}", MinAge);
        }
    }
}
