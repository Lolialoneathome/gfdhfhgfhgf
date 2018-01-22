using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Nodes
{
    public class Node
    {
        public string Name { get; set; }
        public List<Node> Children;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var node = new Node()
            {
                Name = "root",
                Children = new List<Node>() {
                        new Node() {
                            Children = new List<Node>(),
                            Name = "emptyChild1"
                        },
                        new Node()
                        {
                            Children = new List<Node>() {
                                new Node() {
                                    Name = "emptyChild2"
                                }
                            },
                            Name = "NotemptyChild"
                        },
                    }
            };

            var result = GetLastChilds(node);
            Console.WriteLine(string.Join(", ", result.Select(x => x.Name)));
            Console.ReadLine();
        }


        public static IEnumerable<Node> GetLastChilds(Node node)
        {
            if (node.Children == null || node.Children.Count == 0)
                return new List<Node> { node };

            var result = new List<Node>();
            foreach (var item in node.Children)
            {
                result.AddRange(GetLastChilds(item));
            }

            return result;
        }
    }
}
