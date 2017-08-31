using System;

namespace _98_ValidateBST
{
    public class TreeNode{
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(2);
            root.right = new TreeNode(4);
            Console.WriteLine(IsValidBST(root));
        }

        public static bool IsValidBST(TreeNode root) {
            bool isValid = true;
            if(root == null) return isValid;
            int originRootVal = root.val;
            TreeNode originRoot = root;
            while(root.left != null) {
                if (root.val <= root.left.val) {
                    isValid = false; 
                    break;
                }
                root = root.left;
            }
            if(isValid){
                while(originRoot.right != null) {
                    if (originRoot.val >= originRoot.right.val && 
                        originRoot.val > originRootVal) {
                        isValid = false; 
                        break;
                    }
                    originRoot = originRoot.right;
                }
            }
            
            return isValid;
        }
    }
}
