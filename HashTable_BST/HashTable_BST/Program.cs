using System;

namespace HashTable_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BST problem");
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Display();
        }
    }
}
