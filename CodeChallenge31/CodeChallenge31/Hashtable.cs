
using CodeChallenge31;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge31
{
    public class Hashtable
    {
        public int Size { get; set; }
        public LinkedList[] Table { get; set; }
        public Hashtable(int size)
        {
            Size = size;
            Table = new LinkedList[size];
        }

        public int Hash(string key)
        {
            int total = 0;
            char[] letters = key.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                total += letters[i];
            }

            int primeValue = total * 599;
            int index = primeValue % Table.Length;

            return index;
        }
        public void Set(string key, string value)
        {
            int index = Hash(key);

            if (Table[index] == null)
            {
                LinkedList ll = new LinkedList();
                Node newNode = new Node(key, value);
                ll.Append(newNode);
                Table[index] = ll;
            }
            else
            {
                Node newNode = new Node(key, value);
                Table[index].Append(newNode);
            }
        }

        public string Get(string key)
        {
            int index = Hash(key);
            var bucket = Table[index];
            bucket.Current = bucket.Head;
            Node current = bucket.Current;

            while (current.Key != key)
            {
                current = current.Next;
            }

            if (current.Key == key)
            {
                return current.Value;
            }
            return null;
        }

        public List<string> Keys(string key)
        {
            int index = Hash(key);
            List<string> output = new List<string>();

            if (Table[index] != null)
            {
                var bucket = Table[index];
                bucket.Current = bucket.Head;
                Node current = bucket.Current;

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        output.Add(current.Value);
                    }
                    current = current.Next;
                }
            }
            return output;
        }

        public bool Has(string key)
        {
            int index = Hash(key);

            if (Table[index] != null)
            {
                var bucket = Table[index];
                bucket.Current = bucket.Head;
                Node current = bucket.Current;

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
            return false;
        }


        public string RepeatedWord(string paragraph)
        {
            string[] words = paragraph.Split(',', ' ', '-', '.');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    if (Has(words[i].ToLower()))
                    {
                        return words[i];
                    }
                    else
                    {
                        Set(words[i].ToLower(), null);
                    }
                }
            }
            return "no repeats";
        }





    }
}