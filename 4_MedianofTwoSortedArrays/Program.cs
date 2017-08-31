using System;

namespace _4_MedianofTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };

            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));
        }

        

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            BinaryTree tree = new BinaryTree();
            tree = tree.sortedArrayToBST(nums1);
            tree.addArrayToBST(tree, nums2);


        }
    }

    // Definition for binary tree
    public class BinaryTree
    {
        int val;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(){

        }
        public BinaryTree(int x)
        {
            val = x;
        }

        public BinaryTree sortedArrayToBST(int[] num)
        {
            if (num.Length == 0)
                return null;

            return sortedArrayToBST(num, 0, num.Length - 1);
        }

        public BinaryTree sortedArrayToBST(int[] num, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;
            BinaryTree root = new BinaryTree(num[mid]);
            root.left = sortedArrayToBST(num, start, mid - 1);
            root.right = sortedArrayToBST(num, mid + 1, end);

            return root;
        }

         public int[] bstToArray(BinaryTree tree)
        {
            if(tree !=null){
                bstToArray(tree.left);
                bstToArray(tree.right);
            }
        }

        public BinaryTree insert(BinaryTree root, int val){
            if(root.val < val) return insert(root.right, val);
            else if(root.val > val) return insert(root.left, val);
            else {
                return new BinaryTree(val);
            }
        }

        // public BinaryTree search(BinaryTree root, int val){
        //     if(root.val < val) return search(root.right, val);
        //     else if(root.val > val) return search(root.left, val);
        //     else 
        // }

        public BinaryTree addArrayToBST(BinaryTree tree, int[] num){
            for(int i=0; i<num.Length; i++){
                BinaryTree tempNode = new BinaryTree(num[i]);
                tree.insert(tree,num[i]);
            }
            return tree;
        }
    }
    // class Node
    // {

    //     int data;
    //     public Node left, right;

    //     public Node(int d)
    //     {
    //         data = d;
    //         left = right = null;
    //     }
    // }

    // class BinaryTree
    // {

    //     static Node root;

    //     /* A function that constructs Balanced Binary Search Tree 
    //      from a sorted array */
    //     Node sortedArrayToBST(int[] arr, int start, int end)
    //     {

    //         /* Base Case */
    //         if (start > end)
    //         {
    //             return null;
    //         }

    //         /* Get the middle element and make it root */
    //         int mid = (start + end) / 2;
    //         Node node = new Node(arr[mid]);

    //         /* Recursively construct the left subtree and make it
    //          left child of root */
    //         node.left = sortedArrayToBST(arr, start, mid - 1);

    //         /* Recursively construct the right subtree and make it
    //          right child of root */
    //         node.right = sortedArrayToBST(arr, mid + 1, end);

    //         return node;
    //     }


    // }
}
