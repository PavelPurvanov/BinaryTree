using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercise_4
{
    public partial class Form1 : Form
    {     
        private List<string> myList;
        private List<string> listRemovedWords;
        private BinaryTree myTree = new BinaryTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listRemovedWords = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\Exercise_4\removeWords.txt").ToLower().Split(' ').ToList();          
        }

        private void button1_test1_Click(object sender, EventArgs e)
        {
            textBox_TextView.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\Exercise_4\file1.txt");
            textBox_InOrder.Text = "";
            textBox_PostOrder.Text = "";
            textBox_PreOrder.Text = "";
            treeView.Nodes.Clear();
        }

        private void button2_test2_Click(object sender, EventArgs e)
        {
            textBox_TextView.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\Exercise_4\file2.txt");
            textBox_InOrder.Text = "";
            textBox_PostOrder.Text = "";
            textBox_PreOrder.Text = "";
            treeView.Nodes.Clear();
        }

        private void button3_test3_Click(object sender, EventArgs e)
        {
            textBox_TextView.Text = File.ReadAllText(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\Exercise_4\file3.txt");
            textBox_InOrder.Text = "";
            textBox_PostOrder.Text = "";
            textBox_PreOrder.Text = "";
            treeView.Nodes.Clear();
        }

        private bool buttonWasClicked = false;
        private void button_BinaryBuild_Click(object sender, EventArgs e)
        {
            Stopwatch myTimer = new Stopwatch();
            label1_buildTime.Text = "0";
            label2_inOrderTime.Text = "0";
            label3_preOrderTime.Text = "0";
            label4_postOrderTime.Text = "0";
            textBox_InOrder.Clear();
            textBox_PreOrder.Clear();
            textBox_PostOrder.Clear(); 

            if (buttonWasClicked)
            {
                treeView.Nodes.Clear();
                myTree = new BinaryTree();
                buttonWasClicked = false;
            }
            if (textBox_TextView.Text == "")
            {
                MessageBox.Show("Please, choose from Test 1 to Test 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                myTimer.Start();
                createTree();
                myTimer.Stop();
                label1_buildTime.Text = myTimer.Elapsed.ToString();
            }
            buttonWasClicked = true;
        }

        private void createTree() {

                myList = textBox_TextView.Text.ToLower().Split(' ', '“', '„', '.', ',', '(', ')', '-', '/', '!', '?', ':', '\n', '\r', '"', '+', '[', ']', ';').ToList();
                myList.RemoveAll(x => x.Length == 0);
                for (int i = 0; i < myList.Count(); i++)
                {
                    for (int j = 0; j < listRemovedWords.Count(); j++)
                    {
                        if (myList[i].Equals(listRemovedWords[j]))
                        {
                            myList.RemoveAt(i);
                        }
                    }
                }

                var groups = myList.GroupBy(v => v);
                foreach (var group in groups)
                {
                    myTree.addNode(group.Key + ", " + group.Count());
                }

                DisplayTree(myTree);
                treeView.ExpandAll();          
       }
        
        private void ShowNode(TreeNodes node, TreeNode treeNode)
        {
            treeNode.Text += node.value;
            if (node.left != null)
            {
                ShowNode(node.left, treeNode.Nodes.Add("Left: "));
            }
            if (node.right != null)
            {
                ShowNode(node.right, treeNode.Nodes.Add("Right: "));
            }
        }

        private void DisplayTree(BinaryTree tree)
        {
            ShowNode(tree.root, treeView.Nodes.Add("Root: "));
        }

        private void InOrder(TreeNodes node)
        {
            if (node != null)
            {
                InOrder(node.left);
                textBox_InOrder.Text +=  node.value.ToString() + System.Environment.NewLine;
                InOrder(node.right);
            }
        }

        private void PreOrder(TreeNodes node)
        {
            if (node != null)
            {
                textBox_PreOrder.Text += node.value.ToString() + System.Environment.NewLine;
                PreOrder(node.left);
                PreOrder(node.right);
            }
        }

        private void PostOrder(TreeNodes node)
        {
            if (node != null)
            {
                PostOrder(node.left);
                PostOrder(node.right);
                textBox_PostOrder.Text += node.value.ToString() + System.Environment.NewLine;
            }
        }    

        private void button_InOrder_Click(object sender, EventArgs e)
        {
            if (myTree.root == null)
            {
                MessageBox.Show("No tree created !","Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Stopwatch myTimer = new Stopwatch();
                textBox_InOrder.Clear();
                myTimer.Start();
                InOrder(myTree.root);
                myTimer.Stop();
                label2_inOrderTime.Text = myTimer.Elapsed.ToString();
            }
        }

        private void button_PreOrder_Click(object sender, EventArgs e)
        {
            if (myTree.root == null)
            {
                MessageBox.Show("No tree created !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Stopwatch myTimer = new Stopwatch();
                textBox_PreOrder.Clear();
                myTimer.Start();
                PreOrder(myTree.root);
                myTimer.Stop();
                label3_preOrderTime.Text = myTimer.Elapsed.ToString();
            }
        }

        private void button_PostOrder_Click(object sender, EventArgs e)
        {
            if (myTree.root == null)
            {
                MessageBox.Show("No tree created !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Stopwatch myTimer = new Stopwatch();
                textBox_PostOrder.Clear();
                myTimer.Start();
                PostOrder(myTree.root);
                myTimer.Stop();
                label4_postOrderTime.Text = myTimer.Elapsed.ToString();
            }
        }      
    }
}
