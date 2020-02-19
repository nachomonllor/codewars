https://www.codewars.com/kata/convert-a-linked-list-to-a-string/csharp


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class Node
        {
            public int Data { get; private set; }
            public Node Next { get; private set; }

            public Node(int data, Node next)
            {
                Data = data;
                Next = next;
            }
        }



        public static string Stringify(Node list)
        {
            // Write your code here
            StringBuilder sb = new StringBuilder();
            for (Node head = list; head != null; head = head.Next)
            {
                sb.Append(head.Data );
                sb.Append(" -> ");
            }
            sb.Append("null");
            return sb.ToString();
        }
        static void Main(string[] args)
        {



            Console.ReadLine();
        }
    }
}
