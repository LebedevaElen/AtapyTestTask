using System;
using System.Collections.Generic;

namespace AtapyTestTask
{
    static public class Translator
    {
        static public Dictionary<Type, string> TranslationDictionary = new Dictionary<Type, string>()
        {
            { typeof(Book), "Книги" },
            { typeof(Disk), "Диски" },
            { typeof(ProgrammingBook), "Книги по программированию" },
            { typeof(CookingBook), "Книги по кулинарии" },
            { typeof(EsotericsBook), "Книги по эзотерике" },
            { typeof(Music), "Музыка" },
            { typeof(Video), "Видео" },
            { typeof(Software), "Программное обеспечение" },
            { typeof(CD), "CD" },
            { typeof(DVD), "DVD" }
        };
    }
}
