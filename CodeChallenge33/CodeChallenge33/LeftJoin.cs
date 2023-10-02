using CodeChallenge33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge33
{
    public static class LeftJoin
    {
        public static List<string> Perform(HashTable left, HashTable right)
        {
            List<string> joinTable = new List<string>();

            for (int i = 0; i < left.Table.Length; i++)
            {
                if (left.Table[i] != null)
                {
                    Node currentNode = left.Table[i];

                    while (currentNode != null)
                    {
                        string concat = $"{currentNode.Key}, {currentNode.Value}, ";

                        if (right.Contains(currentNode.Key))
                        {
                            concat += right.Get(currentNode.Key);
                        }
                        else
                        {
                            concat += "NULL";
                        }

                        joinTable.Add(concat);
                        currentNode = currentNode.Next;
                    }
                }
            }

            return joinTable;
        }
    }
}