﻿using System;

namespace HashTable_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable problem");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(6);
            hash.Add(0, "To");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");
            Operation operation = new Operation();
            operation.Frequency(hash);
        }
    }
}
