﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.SearchHandler
{
    class SubjectStack
    {
        public SubjectStack before { get; set; }
        public List<SubjectStack> after { get; set; }
        public int rootId { get; set; }
        public int subId { get; set; }
        public string subName { get; set; }
        public SubjectStack(int sub, int root, string name)
        {
            after = new List<SubjectStack>();
            rootId = root;
            subId = sub;
            subName = name;
        }
        public SubjectStack()
        {
            after = new List<SubjectStack>();
        }
        public bool IsLeaf()
        {
            return after.Count == 0;
        }

        public void PushStack(SubjectStack s)
        {
            after.Add(s);
            Console.WriteLine("Pushed sub: " + s.subId + " " + s.subName);
        }
        
        public SubjectStack GetSubWithID(int id, List<SubjectStack> temp)
        {
            
            //bool found = false;
            foreach (SubjectStack s in temp)
            {
                if (s.subId == id)
                {
                    foreach (SubjectStack ss in s.after)
                        Console.WriteLine("Found sub: " + ss.subId + " " + ss.subName);
                    return s;
                    
                    //return s;
                }
            }
            SubjectStack ret = new SubjectStack();
            foreach (SubjectStack s in temp)
            {
                if(s.subId != id)
                {
                    return GetSubWithID(id, s.after);
                    
                    //break;
                    //Console.WriteLine("Found sub: " + s.subId + " " + s.subName);
                }
            }
            return ret;
        }
        //private List<SubjectStack> testtemp = new List<SubjectStack>();
        public void ReplaceSub(int id, SubjectStack sub, List<SubjectStack> temp)
        {
            //SubjectStack deleted;
            
            for (int i = 0; i < temp.Count; i++)
            {
                SubjectStack s = temp[i];
                if (s.subId != id)
                {

                    ReplaceSub(id, sub, s.after);
                    
                }
                
            }
            for (int i = 0; i < temp.Count; i++)
            {
                SubjectStack s = temp[i];
                if (s.subId == id)
                {
                    temp[i].after = sub.after;
                    
                    
                    Console.WriteLine("Removed sub: " + s.subId + " " + s.subName);
                }
            }

        }
    }
}
