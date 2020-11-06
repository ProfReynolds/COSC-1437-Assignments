﻿using System;
using System.Diagnostics;

/*
 * ProfReynolds
 */

namespace NodeChains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProfReynolds NodeChains");
            Console.WriteLine();

            /*
             * creating the first node
             * since there is no second node, the Next property is null
             */
            var first = new Node { Value = 3 };
            //    +-----+------+
            //    |  3  | null +
            //    +-----+------+
            Debug.WriteLine($"\nnode #1: Value = {first.Value}, Next node = {first.Next?.Value}");


            /*
             * creating the second node
             * now the first node 'points' to the second node
             * but there is no third node, the Next property in the second node is null
             */
            var second = new Node { Value = 5 };
            first.Next = second;
            //    +-----+------+    +-----+------+
            //    |  3  | null +    |  5  | null +
            //    +-----+------+    +-----+------+
            Debug.WriteLine($"\nnode #1: Value = {first.Value}, Next node = {first.Next?.Value}");
            Debug.WriteLine($"node #2: Value = {second.Value}, Next node = {second.Next?.Value}");


            /*
             * similarly, the second node points to the third, but the third points nowhere
             */
            var third = new Node { Value = 7 };
            second.Next = third;
            //    +-----+------+    +-----+------+   +-----+------+
            //    |  3  |  *---+--->|  5  |  *---+-->|  7  | null +
            //    +-----+------+    +-----+------+   +-----+------+
            Debug.WriteLine($"\nnode #1: Value = {first.Value}, Next node = {first.Next?.Value}");
            Debug.WriteLine($"node #2: Value = {second.Value}, Next node = {second.Next?.Value}");
            Debug.WriteLine($"node #3: Value = {third.Value}, Next node = {third.Next?.Value}");


            var fourth = new Node { Value = 4444 };
            third.Next = fourth;
            Debug.WriteLine($"\nnode #1: Value = {first.Value}, Next node = {first.Next?.Value}");
            Debug.WriteLine($"node #2: Value = {second.Value}, Next node = {second.Next?.Value}");
            Debug.WriteLine($"node #3: Value = {third.Value}, Next node = {third.Next?.Value}");
            Debug.WriteLine($"node #4: Value = {fourth.Value}, Next node = {fourth.Next?.Value}");


            var fifth = new Node { Value = 55555 };
            fourth.Next = fifth;
            Debug.WriteLine($"\nnode #1: Value = {first.Value}, Next node = {first.Next?.Value}");
            Debug.WriteLine($"node #2: Value = {second.Value}, Next node = {second.Next?.Value}");
            Debug.WriteLine($"node #3: Value = {third.Value}, Next node = {third.Next?.Value}");
            Debug.WriteLine($"node #4: Value = {fourth.Value}, Next node = {fourth.Next?.Value}");
            Debug.WriteLine($"node #5: Value = {fifth.Value}, Next node = {fifth.Next?.Value}");


            var r = new Random();
            var workingNode = fifth;
            for (var anotherNode = 0; anotherNode < 5; anotherNode++)
            {
                var newRandomValue = r.Next(100, 200);

                workingNode.Next = new Node()
                    {
                        Value = newRandomValue
                    };

                workingNode = workingNode.Next;
            }


            // now iterate over each node and print the value
            Console.WriteLine("\n\nPrinting Iteratively");
            PrintListIteratively(first);


            // just for practice, print recursively
            Console.WriteLine("\n\nPrinting Recursively");
            PrintListRecursively(first);

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void PrintListIteratively(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        private static void PrintListRecursively(Node node)
        {
            if (node == null) return;

            Console.WriteLine(node.Value);
            PrintListRecursively(node.Next);
        }

    }
}
