using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.SearchHandler
{
    class TreeItem
    {
        public string sname { get; set; }
        public int rootId { get; set; }
        public int level { get; set; }
        public int id { get; set; }

        public TreeItem(string name, int root, int level, int id)
        {
            sname = name;
            rootId = root;
            this.level = level;
            this.id = id;
        }
    }
}
