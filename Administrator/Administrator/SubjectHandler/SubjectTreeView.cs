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

        public static void AddRoot(TreeView treeview,TreeNode node)
        {
            treeview.Nodes.Add(node);
        }
        
        public static void AddNodes(TreeNode node, int number, string name, int id)
        {
            if (number > 0 && node != null)
            {
                TreeNode childNode = new TreeNode(name);
                childNode.Name = name;
                childNode.Tag = id;

                node.Nodes.Add(childNode);

                AddNodes(node,--number,name,id);
            }
        }

    }
}
