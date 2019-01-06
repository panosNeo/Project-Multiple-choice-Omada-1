using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Administrator.SubjectHandler
{
    static class SubjectTreeView
    {
        //prwtou epipedou nodes
        public static void AddRoot(TreeView treeview,TreeNode node)
        {
            treeview.Nodes.Add(node);
        }
        
        //deuterou epipedou nodes
        public static void AddNodes(TreeNode node,int number,List<string> name,List<int> id)
        {
            if (number > -1 && node != null)
            {
                TreeNode childNode = new TreeNode(name[number]);
                childNode.Name = name[number];
                childNode.Tag = id[number];
                
                node.Nodes.Add(childNode);

                AddNodes(node,--number,name,id);
            }
        }

    }
}
