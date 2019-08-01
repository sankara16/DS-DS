using DSLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLibrary.Tree
{
    public class HuffmanTree
    {
        private List<HuffmanNode> nodes = new List<HuffmanNode>();

        public HuffmanNode Root { get; set; }

        public Dictionary<char, int> Frequencies = new Dictionary<char, int>();

        public void Build(string source)
        {
            // Find the characters and its frequencies 
            for (int i = 0; i < source.Length; i++)
            {
                if (!Frequencies.ContainsKey(source[i]))
                {
                    Frequencies.Add(source[i], 0);
                }
                Frequencies[source[i]]++;
            }

            // add the char and its frequencies like nodes in nodes
            foreach (KeyValuePair<char, int> keyValuePair in Frequencies)
            {
                nodes.Add(new HuffmanNode() { Symbol = keyValuePair.Key, Frequency = keyValuePair.Value });
            }

            while (nodes.Count > 1)
            {
                // need to arrange in ascending order before build the tree.
                List<HuffmanNode> orderedNodes = nodes.OrderBy(o => o.Frequency).ToList<HuffmanNode>();

                if (orderedNodes.Count >= 2)
                {
                    List<HuffmanNode> taken = orderedNodes.Take(2).ToList<HuffmanNode>();

                    HuffmanNode parent = new HuffmanNode()
                    {
                        Left = taken[0],
                        Right = taken[1],
                        Symbol = '*',
                        Frequency = taken[0].Frequency + taken[1].Frequency
                    };

                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent);
                }

                this.Root = nodes.FirstOrDefault();
            }
        }

        public BitArray Encode(string source)
        {
            List<bool> encodedSource = new List<bool>();

            for (int i = 0; i < source.Length; i++)
            {
                List<bool> encodedSymbol = this.Root.Traverse(source[i], new List<bool>());

                encodedSource.AddRange(encodedSymbol);
            }

            BitArray bitArray = new BitArray(encodedSource.ToArray());

            return bitArray;
        }

        public string Decode(BitArray bits)
        {
            HuffmanNode current = this.Root;

            string decoded = "";

            foreach (bool bit in bits)
            {
                if (bit)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                }

                if (IsLeaf(current))
                {
                    decoded += current.Symbol;
                    current = this.Root;
                }
            }

            return decoded;
        }

        private bool IsLeaf(HuffmanNode current)
        {
            return (current.Left == null && current.Right == null);
        }
    }
}
