using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marvelReset.Dtos
{
    public class URL
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Image
    {
        public string path { get; set; }
        public string extension { get; set; }
    }

    public class TextObject
    {
        public string type { get; set; }
        public string language { get; set; }
        public string text { get; set; }
    }
}
