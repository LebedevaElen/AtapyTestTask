using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtapyTestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var Items = GetItemsList();
            
            var Books = from item in Items
                        where item.GetType().BaseType == Type.GetType("AtapyTestTask.Book")
                        group item by item.GetType();

            var Disks = from item in Items
                        where item.GetType().BaseType == Type.GetType("AtapyTestTask.Disk")
                        group item by item.GetType();

            Console.Out.WriteLine("КНИГИ\n");
            PrintGroup(Books);
            Console.Out.WriteLine("ДИСКИ\n");
            PrintGroup(Disks);

            Console.ReadKey();
        }

        static void PrintGroup(IEnumerable<IGrouping<Type, Item>> Groups)
        {
            foreach (var group in Groups)
            {
                string category;
                if (Translator.Dict.TryGetValue(group.Key, out category))
                    Console.Out.WriteLine(category + "\n");
                else
                    Console.Out.WriteLine(group.Key.Name + "\n");

                foreach (var elem in group)
                {
                    elem.PrintProperties();
                    Console.Out.WriteLine();
                }
            }
        }

        static List<Item> GetItemsList()
        {
            return new List<Item>()
            {
                new ProgrammingBook { Name = "Deep Learning", Price = 735.50f, Barcode = "1", PageCount = 710, ProgLanguage = "Python" },
                new ProgrammingBook { Name = "Effective C++", Price = 450.00f, Barcode = "2", PageCount = 430, ProgLanguage = "C++" },
                new CookingBook { Name = "All About Cookies", Price = 320.00f, Barcode = "3", PageCount = 310, MainIngredient = "Flour"},
                new EsotericsBook { Name = "The Secret Teachings of All Ages", Price = 870.00f, Barcode = "4", PageCount = 1055, MinAge = 16},
                new EsotericsBook { Name = "The Art of Dreaming", Price = 421.60f, Barcode = "5", PageCount = 254, MinAge = 6 },
                new CD { Name = "The Wall", Price = 450.00f, Barcode = "6", Content = new Music() },
                new CD { Name = "The Fellowship Of The Ring", Price = 540.00f, Barcode = "7", Content = new Video() },
                new CD { Name = "Photoshop", Price = 1000.00f, Barcode = "8", Content = new Software() },
                new DVD { Name = "Beautiful Garbage", Price = 500.00f, Barcode = "9", Content = new Music() },
                new DVD { Name = "The Fifth Element", Price = 400.00f, Barcode = "10", Content = new Video() },
                new DVD { Name = "Windows XP", Price = 1300.00f, Barcode = "11", Content = new Software() }
            };
        }
    }
}
