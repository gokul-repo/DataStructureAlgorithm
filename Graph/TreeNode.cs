using System.Collections.Generic;

namespace DataStructureAlgorithm.Graph
{
    public class TreeNode
    {
        public int Id;
        public TreeNode ParentNode;
        public List<TreeNode> ChildrenNodes;  
        public TreeNode(int id){
            Id = id;
            ParentNode=null;
            ChildrenNodes = new List<TreeNode>();
        }
        public TreeNode(int id, TreeNode parent){
            Id=id;
            ParentNode=parent;
            ChildrenNodes = new List<TreeNode>();
        }        

        public TreeNode BuildTree(Dictionary<int, List<Edge>> Graph, TreeNode root){
            
            if(Graph.ContainsKey(root.Id)){
                foreach(var child in Graph[root.Id]){
                    if (root.ParentNode != null && child.To == root.ParentNode.Id){
                        continue;
                    }
                    TreeNode childNode = new TreeNode(child.To,root);
                    root.ChildrenNodes.Add(childNode);
                    BuildTree(Graph,childNode);
                }
            }
            return root;
        }
    }    
}