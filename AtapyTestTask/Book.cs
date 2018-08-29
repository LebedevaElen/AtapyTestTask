using System;

namespace AtapyTestTask
{
    abstract public class Book : Item
    {
        public int PageCount { get; set; }

        public override void PrintProperties(int level = 0)
        {
            base.PrintProperties(level);
            var tabs = new String('\t', level);
            Console.Out.WriteLine(tabs + "Количество страниц: " + PageCount);
        }
    }

    public class ProgrammingBook : Book
    {
        public string ProgLanguage { get; set; }

        public override void PrintProperties(int level = 0)
        {
            base.PrintProperties(level);
            var tabs = new String('\t', level);
            Console.Out.WriteLine(tabs + "Язык программирования: " + ProgLanguage);
        }
    }

    public class CookingBook : Book
    {
        public string MainIngredient { get; set; }

        public override void PrintProperties(int level = 0)
        {
            base.PrintProperties(level);
            var tabs = new String('\t', level);
            Console.Out.WriteLine(tabs + "Основной ингредиент: " + MainIngredient);
        }
    }

    public class EsotericsBook : Book
    {
        public int MinAge { get; set; }

        public override void PrintProperties(int level = 0)
        {
            base.PrintProperties(level);
            var tabs = new String('\t', level);
            Console.Out.WriteLine(tabs + "Минимальный возраст читателя: " + MinAge);
        }
    }
}
