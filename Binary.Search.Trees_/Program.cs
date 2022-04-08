﻿using System;
using System.Collections.Generic;
using System.Collections;

namespace Binary.Search.Trees
{
    
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
    class Solution
    {

        static int getHeight(Node root)
        {

            
            if (root==null)
            {
                return -1;
            }

            int lefHeight =getHeight(root.left);
            int rightHeight =getHeight(root.right); 

            if (lefHeight > rightHeight)
            {
                return lefHeight+1;
            }
            else
            {
                return rightHeight + 1;
            }




        }
        

        static Node insert(Node root, int data)// 7 3 5 2 1 4 6 7

      {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);

        }
    }
}
