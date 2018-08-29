using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static AtapyTestTask.Translator;

namespace AtapyTestTask
{
    class Program
    {
        static void Main()
        {
            List<Item> items = GetItemsList();
            /* all categories and subcategories of goods */
            IEnumerable<Type> types = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(Item)));
            HeirarchyPrint(0, typeof(Item), types, items);

            Console.ReadKey();
        }

        /* Calls itself recursively for each parent subcategory printing its name
         * and then prints all parent subcategories items info. */
        static void HeirarchyPrint(int level, Type parent, IEnumerable<Type> types, List<Item> items)
        {
            var subcategories = types.Where(type => type.BaseType == parent);
            var tabs = new String('\t', level);
            foreach (var subcategory in subcategories)
            {
                if (TranslationDictionary.TryGetValue(subcategory, out string name))
                    Console.Out.WriteLine(tabs + name + "\n");
                else
                    Console.Out.WriteLine(tabs + subcategory.Name + "\n");
                
                HeirarchyPrint(level + 1, subcategory, types, items);
                
                var itemsGroup = items.Where(item => item.GetType() == subcategory);
                foreach (var item in itemsGroup)
                {
                    item.PrintProperties(level + 1);
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
                new CookingBook { Name = "All About Cookies", Price = 320.00f, Barcode = "3", PageCount = 310, MainIngredient = "Мука"},
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
