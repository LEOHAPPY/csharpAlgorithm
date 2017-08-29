using System;
using System.Collections;
using System.Collections.Generic;

namespace AddTwoNumbers
{
    class ListNode{
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        // public ListNode() {}

        // private ListNode head;

        // public void addLast (int x){
        //     if(head == null){
        //         head = new ListNode();
        //         head.next = null;
        //         head.val = x;
        //     }else{
        //         ListNode toAdd = new ListNode(x);
        //         ListNode current = head;
        //         while (current.next != null)
        //         {
        //             current = current.next;
        //         }

        //         current.next = toAdd;
        //     }
        // }
        // public void printAllNodes()
        // {
        //     ListNode current = head;
        //     while (current != null)
        //     {
        //         Console.WriteLine(current.val);
        //         current = current.next;
        //     }
        // }

    }

    class Program
    {
        
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(3);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(8);
            l2.next.next.next = new ListNode(9);

            ListNode result = addTwoNumbers(l1,l2);
            while(result != null){
                Console.WriteLine(result.val);
                result = result.next;
            }
            // result.printAllNodes();

        }
        

        public static ListNode addTwoNumbers(ListNode l1, ListNode l2) {
    //         //initialize result - a ListNode 
    //         ListNode result = new ListNode();
    //         int proceed = 0;

    //         while (l1 !=null || l2 !=null){
    //             int l1V = l1 == null ? 0 : l1.val;
    //             int l2V = l2 == null ? 0 : l2.val;
                
    //             int sum = l1V + l2V;
    //             result.addLast((sum%10 + proceed)%10);

    //             if(sum>=10)
    //                 proceed = 1;
    //             else
    //                 proceed = 0;

    //             if (l1 != null)
    //                 l1 = l1.next;
    //             if (l2 != null)
    //                 l2 = l2.next;
    //         }
    //         return result;

        //must have a temp curr, a head which is attached to curr for saving each iteratoration
        // ListNode dummyHead = new ListNode(0);
        // ListNode p = l1, q = l2;
        // ListNode curr = dummyHead;

        // int carry = 0;
        // while (p != null || q != null) {
        //     int x = (p != null) ? p.val : 0;
        //     int y = (q != null) ? q.val : 0;
        //     int sum = carry + x + y;
        //     carry = sum / 10; //get fist number
        //     curr.next = new ListNode(sum % 10);
        //     curr = curr.next;//replace the previous one -- get current node

        //     if (p != null) p = p.next;
        //     if (q != null) q = q.next;
        // }
        // if (carry > 0) {
        //     curr.next = new ListNode(carry);
        // }
        // //why dummyHead get ref from curr? updated automatically
        // return dummyHead.next;
        // }
        ListNode Head = new ListNode(0);
        ListNode curr = Head;
        
        int carry = 0;
        while(l1.next != null || l2.next != null){
            int l1v = l1 == null ? 0 : l1.val;
            int l2v = l2 == null ? 0 : l2.val;
            
            int sum = l1v + l2v + carry;
            carry = sum/10;
            curr.next = new ListNode(sum%10);
            curr = curr.next;
            
            if(l1.next != null) l1 = l1.next;
            if(l2.next != null) l2 = l2.next;
        }
        if (carry>0){
            curr = new ListNode(carry);
        }
        return Head.next;
    }
}
}
//     public class Node
// {
//     public Node next;
//     public Object data;
// }

// public class LinkedList
// {
//     private Node head;

//     public void printAllNodes()
//     {
//         Node current = head;
//         while (current != null)
//         {
//             Console.WriteLine(current.data);
//             current = current.next;
//         }
//     }

//     public void AddFirst(Object data)
//     {
//         Node toAdd = new Node();

//         toAdd.data = data;
//         toAdd.next = head;

//         head = toAdd;
//     }

//     public void AddLast(Object data)
//     {
//         if (head == null)
//         {
//             head = new Node();

//             head.data = data;
//             head.next = null;
//         }
//         else
//         {
//             Node toAdd = new Node();
//             toAdd.data = data;

//             Node current = head;
//             while (current.next != null)
//             {
//                 current = current.next;
//             }

//             current.next = toAdd;
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Add First:");
//         LinkedList myList1 = new LinkedList();

//         myList1.AddFirst("Hello");
//         myList1.AddFirst("Magical");
//         myList1.AddFirst("World");
//         myList1.printAllNodes();

//         Console.WriteLine();

//         Console.WriteLine("Add Last:");
//         LinkedList myList2 = new LinkedList();

//         myList2.AddLast("Hello");
//         myList2.AddLast("Magical");
//         myList2.AddLast("World");
//         myList2.printAllNodes();

//         Console.ReadLine();
//     }
// }

