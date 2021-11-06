using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_ADMIN.Models
{
    public class BookData
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public string Category { get; set; }

        public string Content { get; set; }
    }
}
