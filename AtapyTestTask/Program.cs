using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static AtapyTestTask.Translator;

namespace AtapyTestTask
{
    class Program
    {
        static List<Item> items;
        static IEnumerable<Type> types;

        static void Main()
        {
            /* список товаров */
            items = GetItemsList();
            /* список категорий товаров всех уровней */
            types = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(Item)));
            /* рекурсивный проход по дереву категорий и вывод информации о товарах */
            HeirarchyPrint(typeof(Item));

            Console.ReadKey();
        }

        static void HeirarchyPrint(Type parent)
        {
            /* получение всех подкатегорий категории parent */ 
            var subcategories = types.Where(type => type.BaseType == parent);
            foreach (var subcategory in subcategories)
            {
                /* вывод названия подкатегории */
                if (TranslationDictionary.TryGetValue(subcategory, out string name))
                    Console.Out.WriteLine(name + "\n");
                else
                    Console.Out.WriteLine(subcategory.Name + "\n");

                /* рекурсивный проход по подкатегориям текущей подкатегории */
                HeirarchyPrint(subcategory);

                /* вывод информации о товарах текущей подкатегории */
                var itemsGroup = items.Where(item => item.GetType() == subcategory);
                foreach (var item in itemsGroup)
                {
                    item.PrintProperties();
                    Console.Out.WriteLine();
                }
            }
        }

        static List<Item> GetItemsList()
        {
            return new List<Item>()
            {
                new DVD { Name = "Windows XP", Price = 1300.00f, Barcode = "11", Content = new Software() },
                new ProgrammingBook { Name = "Deep Learning", Price = 735.50f, Barcode = "1", PageCount = 710, ProgLanguage = "Python" },
                new CD { Name = "The Fellowship Of The Ring", Price = 540.00f, Barcode = "7", Content = new Video() },
                new CookingBook { Name = "All About Cookies", Price = 320.00f, Barcode = "3", PageCount = 310, MainIngredient = "Flour"},
                new EsotericsBook { Name = "The Art of Dreaming", Price = 421.60f, Barcode = "5", PageCount = 254, MinAge = 6 },
                new CD { Name = "The Wall", Price = 450.00f, Barcode = "6", Content = new Music() },
                new ProgrammingBook { Name = "Effective C++", Price = 450.00f, Barcode = "2", PageCount = 430, ProgLanguage = "C++" },
                new CD { Name = "Photoshop", Price = 1000.00f, Barcode = "8", Content = new Software() },
                new DVD { Name = "Beautiful Garbage", Price = 500.00f, Barcode = "9", Content = new Music() },
                new EsotericsBook { Name = "The Secret Teachings of All Ages", Price = 870.00f, Barcode = "4", PageCount = 1055, MinAge = 16},
                new DVD { Name = "The Fifth Element", Price = 400.00f, Barcode = "10", Content = new Video() }
            };
        }
    }
}
