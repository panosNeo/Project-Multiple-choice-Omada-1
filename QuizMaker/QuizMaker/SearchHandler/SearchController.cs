using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker.SearchHandler
{
    class SearchController
    {
        public static TreeNode GetSubjects()
        {
            MultipleChoiceDataSetTableAdapters.SubjectTableAdapter subject = new MultipleChoiceDataSetTableAdapters.SubjectTableAdapter();
            List<MultipleChoiceDataSet.SubjectRow> nodeList = new List<MultipleChoiceDataSet.SubjectRow>();
            SubjectStack sub = new SubjectStack();
            SubjectStack temp = new SubjectStack();
            
            foreach (var d in subject.GetData()) 
            {
                
                nodeList.Add(d);
                if(d.Root_id == 0)
                {
                    sub = new SubjectStack(d.Subject_id, d.Root_id, d.S_name);
                }
                
                else if(d.Root_id == 1)
                {
                    sub.PushStack(new SubjectStack(d.Subject_id, d.Root_id, d.S_name));
                }
                else
                {
                    temp = sub.GetSubWithID(d.Root_id, sub.after);
                    //Console.WriteLine(temp.subId);
                    if(temp != null)
                    {
                        temp.PushStack(new SubjectStack(d.Subject_id, d.Root_id, d.S_name));
                        foreach (SubjectStack test in temp.after)
                            Console.WriteLine(test.subName);
                        sub.ReplaceSub(d.Root_id, temp, sub.after);
                    }
                    
                }
                

            }
            SortArray(nodeList);
            
            return SeeThroughStack(sub);
            //Console.WriteLine("done");
        }
        private static TreeNode SeeThroughStack(SubjectStack sss)
        {
            var dtemp = new TreeNode(sss.subName);
            foreach(SubjectStack temp in sss.after)
            {
                //Console.WriteLine(temp.subId + " " + temp.rootId + " " + temp.subName);
                if (!temp.IsLeaf())
                {
                    dtemp.Nodes.Add(SeeThroughStack(temp));
                }
            }
            foreach (SubjectStack temp in sss.after)
            {
                if (temp.IsLeaf())
                {
                    dtemp.Nodes.Add(new TreeNode(temp.subName));
                }
            }
            return dtemp;
        }
        private static List<MultipleChoiceDataSet.SubjectRow> SortArray(List<MultipleChoiceDataSet.SubjectRow> l)
        {
            MultipleChoiceDataSet.SubjectRow temp;

            for (int write = 0; write < l.Count; write++)
            {
                for (int sort = 0; sort < l.Count - 1; sort++)
                {
                    if (l[sort].Root_id > l[sort + 1].Root_id)
                    {
                        temp = l[sort + 1];
                        l[sort + 1] = l[sort];
                        l[sort] = temp;
                    }
                }
            }
            
            return l;

        }
        private static TreeNode getTree(List<MultipleChoiceDataSet.SubjectRow> l, int pos)
        {
            var temp = new TreeNode(l[pos].S_name);
            var depth = new TreeNode();
            int tempRoot = 1;
            foreach(MultipleChoiceDataSet.SubjectRow row in l)
            {
                if(row.Root_id == tempRoot)
                {
                    temp.Nodes[tempRoot - 1].Nodes.Add(new TreeNode(row.S_name));
                }
                else
                {
                    depth.Nodes.Add(new TreeNode(row.S_name));
                }
            }
            return temp;
        }
        public static void SetSubjects()
        {
            MultipleChoiceDataSetTableAdapters.SubjectTableAdapter subject = new MultipleChoiceDataSetTableAdapters.SubjectTableAdapter();
            subject.InsertQuery(0,"Root");//1
            subject.InsertQuery(1, "Technology");//2
            subject.InsertQuery(1, "Physics");//3
            subject.InsertQuery(1, "Math");//4
            subject.InsertQuery(1, "History");//5
            subject.InsertQuery(1, "Chemistry");//6
            subject.InsertQuery(2, "Programming");//7
            subject.InsertQuery(2, "Networking");//8
            subject.InsertQuery(3, "AstroPhysics");//9
            subject.InsertQuery(3, "Quantum Physics");//10
            subject.InsertQuery(4, "Algebra");//11
            subject.InsertQuery(4, "Geometry");//12
            subject.InsertQuery(7, "HTML");//13
            subject.InsertQuery(7, "Java");//14
            subject.InsertQuery(7, "C#");//13
            subject.InsertQuery(7, "Python");//13
            subject.InsertQuery(14, "Recursion");//14
            subject.InsertQuery(13, "CSS");//13
            subject.InsertQuery(9, "Stars");//9

        }
    }
}
