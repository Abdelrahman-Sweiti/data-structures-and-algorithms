using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeChallenge33
{
    public class HashTable
    {
        private const int Size = 100;
        public Node[] Table { get; }

        public HashTable()
        {
            Table = new Node[Size];
        }

        public void Insert(string key, string value)
        {
            int index = GetHash(key);

            if (Table[index] == null)
            {
                Table[index] = new Node(key, value);
            }
            else
            {
                Node newNode = new Node(key, value);
                newNode.Next = Table[index];
                Table[index] = newNode;
            }
        }

        public bool Contains(string key)
        {
            int index = GetHash(key);

            Node currentNode = Table[index];

            while (currentNode != null)
            {
                if (currentNode.Key == key)
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public string Get(string key)
        {
            int index = GetHash(key);

            Node currentNode = Table[index];

            while (currentNode != null)
            {
                if (currentNode.Key == key)
                {
                    return currentNode.Value;
                }

                currentNode = currentNode.Next;
            }

            return null; // Return null if key is not found
        }

        private int GetHash(string key)
        {
            int hash = 0;
            foreach (char c in key)
            {
                hash += c;
            }
            return hash % Size;
        }
    }
}