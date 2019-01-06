using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.SearchHandler
{
    class TransferList
    {
        public List<SubjectStack> temp = new List<SubjectStack>();
        public TransferList(List<SubjectStack> l)
        {
            temp = l;
        }
        public List<SubjectStack> getList()
        {
            return temp;
        }
    }
}
