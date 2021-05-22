using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Datamodel
{
    public class News
    {
        public int NewsId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public int CategoryId { get; set; }
        public bool IsFrontNew { get; set; }
        public bool IsDisplayInScroll { get; set; }
        public int Views { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime PostedDate { get; set; }

    }
}
