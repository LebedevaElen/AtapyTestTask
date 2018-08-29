using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtapyTestTask
{
    abstract public class DiskContent { }

    public class Music : DiskContent { }

    public class Video : DiskContent { }

    public class Software : DiskContent { }

    abstract public class Disk : Item
    {
        public DiskContent Content { get; set; }

        public override void PrintProperties()
        {
            base.PrintProperties();
            Console.Out.WriteLine("Содержание: {0}", Translator.Dict[Content.GetType()]);
        }
    }

    public class CD : Disk { }

    public class DVD : Disk { }

}
