using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public void Insert(T value)
        {
            root = InsertRecursive(root, value);
        }

        private Node<T> InsertRecursive(Node<T> node, T value)
        {
            if (node == null)
                return new Node<T>(value);

            if (value.CompareTo(node.Value) < 0)
                node.Left = InsertRecursive(node.Left, value);
            else
                node.Right = InsertRecursive(node.Right, value);

            return node;
        }

        public void InOrderTraversal()
        {
            InOrderRecursive(root);
        }

        private void InOrderRecursive(Node<T> node)
        {
            if (node == null)
                return;

            InOrderRecursive(node.Left);
            Console.WriteLine(node.Value);
            InOrderRecursive(node.Right);
        }
    }
}
