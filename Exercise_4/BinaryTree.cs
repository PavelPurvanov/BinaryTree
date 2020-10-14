using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise_4
{
    class TreeNodes
    {
        public string value;
        public TreeNodes left { get; set; }
        public TreeNodes right { get; set; }

        public TreeNodes(string data)
        {
            this.value = data;
        }
    }

    class BinaryTree
    {
        public TreeNodes root;
        
        public BinaryTree()
        {
            root = null;
        }

        public void addNode(string node)
        {
            TreeNodes newItem = new TreeNodes(node);

            if (root == null)
            {
                root = newItem;
            }
            else
            {
                TreeNodes current = root;
                TreeNodes parent = null;

                while (current != null)
                {
                    parent = current;
                    
                    if (String.Compare(node, current.value) < 0)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newItem;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newItem;
                        }
}}}}}}
