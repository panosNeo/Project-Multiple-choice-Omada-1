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
        //treeNode gia ta subject Nodes pou exoun childs
        private static TreeNode childNode;

        private static bool checkIfExist = false;

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

        //methodos gia ton elegxo enos Subject node
        public static void SearchChildNodes(TreeNode parentNode, int id)
        {
            //des an to subject node exei childs me id idio gia ena neo subject
            //an exei tote dwse ta stoixeia toy subject.child node sto childNode
            foreach (TreeNode node in parentNode.Nodes)
            {
                if (node.Tag.Equals(id))
                    childNode = node;
                SearchChildNodes(node, id);
            }
        }

        //methodos gia na dw an uparxei ena tree node
        public static void CheckIfExistNode(TreeNode parentNode, int id)
        {
            //des an to subject node exei childs me id idio gia ena neo subject
            //an exei tote dwse ta stoixeia toy subject.child node sto childNode
            checkIfExist = false;
            if (parentNode != null) {
                foreach (TreeNode node in parentNode.Nodes)
                {
                    if (node.Tag.Equals(id))
                        checkIfExist = true;
                    CheckIfExistNode(node, id);
                }
            }
        }

        public static bool GetCheckIfExist()
        {
            return checkIfExist;
        }

        //gurise to childNode
        public static TreeNode GetChildNode()
        {
            return childNode;
        }
    }
}
