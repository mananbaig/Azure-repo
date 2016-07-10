﻿using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Management.V2.Resource.DAG
{
    public class DAGraph<NodeDataT, NodeT> : Graph<NodeDataT, NodeT> where NodeT : DAGNode<NodeDataT> 
    {
        private Queue<string> queue;
        private NodeT rootNode;

        public DAGraph(NodeT rootNode)
        {
            this.rootNode = rootNode;
            queue = new Queue<string>();
            this.rootNode.SetPreparer(true);
            this.AddNode(rootNode);
        }

        public bool IsRootNode(NodeT node)
        {
            return this.rootNode == node;
        }

        public bool IsPreparer
        {
            get
            {
                return this.rootNode.IsPreparer;
            }
        }

        public void Merge(DAGraph<NodeDataT, NodeT> parent)
        {
            parent.rootNode.AddDependency(rootNode.Key);
            foreach(KeyValuePair<string, NodeT> item in this.graph) {
                if (!parent.graph.ContainsKey(item.Key))
                {
                    parent.graph.Add(item.Key, item.Value);
                }
            }
        }

        public void Prepare()
        {
            if (IsPreparer)
            {
                foreach(NodeT node in graph.Values)
                {
                    node.Initialize(); // clear dependent and set ToBeResolved count
                    if (!this.IsRootNode(node))
                    {
                        node.SetPreparer(false);
                    }
                }
                InitializeDependentKeys();
                InitializeQueue();
            }
        }

        public NodeT GetNext()
        {
            if (queue.Any())
            {
                return GetNode(queue.Dequeue());
            }
            return null;
        }

        public NodeDataT GetNodeData(string key)
        {
            return GetNode(key).Data;
        }

        public void ReportCompleted(NodeT dependency)
        {
            dependency.SetPreparer(true);
            foreach (string dependentKey in dependency.DependentKeys)
            {
                NodeT dependent = GetNode(dependentKey);
                dependent.ReportCompleted(dependency.Key);
                if (dependent.HasAllResolved)
                {
                    queue.Enqueue(dependent.Key);
                }
            }
        }

        private void InitializeDependentKeys()
        {
            Visit((NodeT node) =>
            {
                if (!node.HasDependencies)
                {
                    return;
                }

                string dependentKey = node.Key;
                foreach (string dependencyKey in node.DependencyKeys)
                {
                    GetNode(dependencyKey).AddDependent(dependentKey);
                }
            });
        }

        private void InitializeQueue()
        {
            queue.Clear();
            foreach(KeyValuePair<string ,NodeT> item in graph)
            {
                if (!item.Value.HasDependencies)
                {
                    queue.Enqueue(item.Key);
                }
            }

            if (queue.Count == 0)
            {
                throw new CircularDependencyException();
            }
        }
    }
}
