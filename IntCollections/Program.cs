using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 10, -30, 10, -5 };

        Stack<int> stack = new Stack<int>(
            new int[] { 1, 10, -30, 10, -5 });

        Queue<int> queue = new Queue<int>(
            new int[] { 1, 10, -30, 10, -5 });

        HashSet<int> hashSet = new HashSet<int>()
        { 1, 10, -30, 10, -5 };

        Console.Write("\nList: ");
        foreach (int i in list)
        {
            Console.Write(i + ", ");
        }

        Console.Write("\nStack: ");
        foreach (int i in stack)
        {
            Console.Write(i + ", ");
        }

        Console.Write("\nQueue: ");
        foreach (int i in queue)
        {
            Console.Write(i + ", ");
        }

        Console.Write("\nHashSet: ");
        foreach (int i in hashSet)
        {
            Console.Write(i + ", ");
        }
        }
    }
}
