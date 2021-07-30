using System.Collections.Generic;

namespace DataStructureAlgorithm.Leetcode
{
    //133. Clone Graph
    //https://leetcode.com/problems/clone-graph/

    public class LocalNode
    {
        public int val;
        public IList<LocalNode> neighbors;

        public LocalNode()
        {
            val = 0;
            neighbors = new List<LocalNode>();
        }

        public LocalNode(int _val)
        {
            val = _val;
            neighbors = new List<LocalNode>();
        }

        public LocalNode(int _val, List<LocalNode> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
    public class CloneGraph
    {
        public Dictionary<LocalNode, LocalNode> myDict = new Dictionary<LocalNode, LocalNode>();
        public LocalNode CloneGraphDFS(LocalNode node)
        {
            if (node == null)
            {
                return null;
            }
            if (myDict.ContainsKey(node))
            {
                return myDict[node];
            }
            var newNode = new LocalNode(node.val);
            myDict.Add(node, newNode);

            foreach (var item in node.neighbors)
            {
                newNode.neighbors.Add(CloneGraphDFS(item));
            }
            return newNode;

        }
        public LocalNode CloneGraphBFS(LocalNode node)
        {
            if (node == null)
            {
                return null;
            }
            Queue<LocalNode> myQueue = new Queue<LocalNode>();
            Dictionary<LocalNode, LocalNode> myDict = new Dictionary<LocalNode, LocalNode>();
            myQueue.Enqueue(node);
            LocalNode newNode = new LocalNode(node.val);
            myDict.Add(node, newNode);
            while (myQueue.Count != 0)
            {
                var n = myQueue.Dequeue();
                foreach (var item in n.neighbors)
                {
                    if (!myDict.ContainsKey(item))
                    {
                        LocalNode cloneNode = new LocalNode (item.val);
                        myDict.Add(item, cloneNode);
                        myQueue.Enqueue(item);
                    }
                    var curr = myDict[n];
                    curr.neighbors.Add(myDict[item]);
                }
            }
            return myDict[node];
        }

    }
}