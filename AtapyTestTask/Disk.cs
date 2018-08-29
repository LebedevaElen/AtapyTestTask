using System;
using static AtapyTestTask.Translator;

namespace AtapyTestTask
{
    abstract public class DiskContent { }

    public class Music : DiskContent { }

    public class Video : DiskContent { }

    public class Software : DiskContent { }

    abstract public class Disk : Item
    {
        public DiskContent Content { get; set; }

        public override void PrintProperties(int level = 0)
        {
            base.PrintProperties(level);
            var tabs = new String('\t', level);
            if (TranslationDictionary.TryGetValue(Content.GetType(), out string name))
                Console.Out.WriteLine(tabs + "Содержание: " + name);
            else
                Console.Out.WriteLine(tabs + "Содержание: " + Content.GetType().Name);
        }
    }

    public class CD : Disk { }

    public class DVD : Disk { }

}
