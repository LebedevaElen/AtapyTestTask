using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtapyTestTask
{
    static public class Translator
    {
        static public Dictionary<Type, string> Dict = new Dictionary<Type, string>()
        {
            { Type.GetType("AtapyTestTask.ProgrammingBook"), "Книги по программированию" },
            { Type.GetType("AtapyTestTask.CookingBook"), "Книги по кулинарии" },
            { Type.GetType("AtapyTestTask.EsotericsBook"), "Книги по эзотерике" },
            { Type.GetType("AtapyTestTask.Music"), "Музыка" },
            { Type.GetType("AtapyTestTask.Video"), "Видео" },
            { Type.GetType("AtapyTestTask.Software"), "Программное обеспечение" },
            { Type.GetType("AtapyTestTask.CD"), "CD" },
            { Type.GetType("AtapyTestTask.DVD"), "DVD" }
        };
    }
}
