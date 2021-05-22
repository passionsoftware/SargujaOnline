using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Datamodel
{
    public class NewsUserVM
    {
        public List<News> AllNews { get; set; }
        public List<NewsTags> Tags { get; set; }

    }
}
