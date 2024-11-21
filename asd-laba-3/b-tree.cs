using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd_laba_3
{
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class BTree
    { 
    public BTree(int degree, string saveFile)
    {
        if (degree < 2)
        {
            throw new ArgumentException("BTree degree must be at least 2", "degree");
        }

        this.Root = new Node(degree);
        this.Degree = degree;
        this.Height = 1;
        this.SaveFilePath = saveFile;
    }
    public string SaveFilePath { get; private set; }
    public Node Root { get; private set; }

    public int Degree { get; private set; }

    public int Height { get; private set; }

    public Entry Search(int key)
    {
        return this.SearchInternal(this.Root, key);
    }
    public Entry Search(int key, ref int comparisons)
    {;
        return this.SearchInternal(this.Root, key, ref comparisons);
    }

    public void Insert(int newKey, string newPointer)
{
    if (!this.Root.HasReachedMaxEntries)
    {
        this.InsertNonFull(this.Root, newKey, newPointer);
        return;
    }

    Node oldRoot = this.Root;
    this.Root = new Node(this.Degree);
    this.Root.Children.Add(oldRoot);
    this.SplitChild(this.Root, 0, oldRoot);
    this.InsertNonFull(this.Root, newKey, newPointer);

    this.Height++;
}

    public void Delete(int keyToDelete)
    {
        this.DeleteInternal(this.Root, keyToDelete);

        if (this.Root.Entries.Count == 0 && !this.Root.IsLeaf)
        {
            this.Root = this.Root.Children.Single();
            this.Height--;
        }
    }

    private void DeleteInternal(Node node, int keyToDelete)
    {
        int i = node.Entries.TakeWhile(entry => keyToDelete.CompareTo(entry.Key) > 0).Count();

        if (i < node.Entries.Count && node.Entries[i].Key.CompareTo(keyToDelete) == 0)
        {
            this.DeleteKeyFromNode(node, keyToDelete, i);
            return;
        }

        if (!node.IsLeaf)
        {
            this.DeleteKeyFromSubtree(node, keyToDelete, i);
        }
    }

    private void DeleteKeyFromSubtree(Node parentNode, int keyToDelete, int subtreeIndexInNode)
    {
        Node childNode = parentNode.Children[subtreeIndexInNode];

        if (childNode.HasReachedMinEntries)
        {
            int leftIndex = subtreeIndexInNode - 1;
            Node leftSibling = subtreeIndexInNode > 0 ? parentNode.Children[leftIndex] : null;

            int rightIndex = subtreeIndexInNode + 1;
            Node rightSibling = subtreeIndexInNode < parentNode.Children.Count - 1
                                            ? parentNode.Children[rightIndex]
                                            : null;

            if (leftSibling != null && leftSibling.Entries.Count > this.Degree - 1)
            {
                childNode.Entries.Insert(0, parentNode.Entries[subtreeIndexInNode]);
                parentNode.Entries[subtreeIndexInNode] = leftSibling.Entries.Last();
                leftSibling.Entries.RemoveAt(leftSibling.Entries.Count - 1);

                if (!leftSibling.IsLeaf)
                {
                    childNode.Children.Insert(0, leftSibling.Children.Last());
                    leftSibling.Children.RemoveAt(leftSibling.Children.Count - 1);
                }
            }
            else if (rightSibling != null && rightSibling.Entries.Count > this.Degree - 1)
            {
                childNode.Entries.Add(parentNode.Entries[subtreeIndexInNode]);
                parentNode.Entries[subtreeIndexInNode] = rightSibling.Entries.First();
                rightSibling.Entries.RemoveAt(0);

                if (!rightSibling.IsLeaf)
                {
                    childNode.Children.Add(rightSibling.Children.First());
                    rightSibling.Children.RemoveAt(0);
                }
            }
            else
            {
                if (leftSibling != null)
                {
                    childNode.Entries.Insert(0, parentNode.Entries[subtreeIndexInNode]);
                    var oldEntries = childNode.Entries;
                    childNode.Entries = leftSibling.Entries;
                    childNode.Entries.AddRange(oldEntries);
                    if (!leftSibling.IsLeaf)
                    {
                        var oldChildren = childNode.Children;
                        childNode.Children = leftSibling.Children;
                        childNode.Children.AddRange(oldChildren);
                    }

                    parentNode.Children.RemoveAt(leftIndex);
                    parentNode.Entries.RemoveAt(subtreeIndexInNode);
                }
                else
                {
                    Debug.Assert(rightSibling != null, "Node should have at least one sibling");
                    childNode.Entries.Add(parentNode.Entries[subtreeIndexInNode]);
                    childNode.Entries.AddRange(rightSibling.Entries);
                    if (!rightSibling.IsLeaf)
                    {
                        childNode.Children.AddRange(rightSibling.Children);
                    }

                    parentNode.Children.RemoveAt(rightIndex);
                    parentNode.Entries.RemoveAt(subtreeIndexInNode);
                }
            }
        }

        this.DeleteInternal(childNode, keyToDelete);
    }

    private void DeleteKeyFromNode(Node node, int keyToDelete, int keyIndexInNode)
    {
        if (node.IsLeaf)
        {
            node.Entries.RemoveAt(keyIndexInNode);
            return;
        }

        Node predecessorChild = node.Children[keyIndexInNode];
        if (predecessorChild.Entries.Count >= this.Degree)
        {
            Entry predecessor = this.DeletePredecessor(predecessorChild);
            node.Entries[keyIndexInNode] = predecessor;
        }
        else
        {
            Node successorChild = node.Children[keyIndexInNode + 1];
            if (successorChild.Entries.Count >= this.Degree)
            {
                Entry successor = this.DeleteSuccessor(predecessorChild);
                node.Entries[keyIndexInNode] = successor;
            }
            else
            {
                predecessorChild.Entries.Add(node.Entries[keyIndexInNode]);
                predecessorChild.Entries.AddRange(successorChild.Entries);
                predecessorChild.Children.AddRange(successorChild.Children);

                node.Entries.RemoveAt(keyIndexInNode);
                node.Children.RemoveAt(keyIndexInNode + 1);

                this.DeleteInternal(predecessorChild, keyToDelete);
            }
        }
    }

    private Entry DeletePredecessor(Node node)
    {
        if (node.IsLeaf)
        {
            var result = node.Entries[node.Entries.Count - 1];
            node.Entries.RemoveAt(node.Entries.Count - 1);
            return result;
        }

        return this.DeletePredecessor(node.Children.Last());
    }

    private Entry DeleteSuccessor(Node node)
    {
        if (node.IsLeaf)
        {
            var result = node.Entries[0];
            node.Entries.RemoveAt(0);
            return result;
        }

        return this.DeletePredecessor(node.Children.First());
    }

    private Entry SearchInternal(Node node, int key)
    {

        int maybeKey = BinarySearch(node.Entries, key);
        if (node.IsLeaf == false)
        {
            if (node.Entries[maybeKey].Key == key)
            {
                return node.Entries[maybeKey];
            }
            else if (key < node.Entries[maybeKey].Key)
            {
                return SearchInternal(node.Children[maybeKey], key);
            }
            else
            {
                return SearchInternal(node.Children[maybeKey + 1], key);
            }
        }
        else
        {
            if(node.Entries[maybeKey].Key == key)
            {
                return node.Entries[maybeKey];
            }
            else
            {
                return null;
            }
        }
    }
    private Entry SearchInternal(Node node, int key,ref int comparisons)
    {
        int maybeKey = BinarySearch(node.Entries, key,ref comparisons);
        if (node.IsLeaf == false)
        {
            if (node.Entries[maybeKey].Key == key)
            {
                return node.Entries[maybeKey];
            }
            else if (key < node.Entries[maybeKey].Key)
            {
                return SearchInternal(node.Children[maybeKey], key, ref comparisons);
            }
            else
            {
                return SearchInternal(node.Children[maybeKey + 1], key, ref comparisons);
            }
        }
        else
        {
            if (node.Entries[maybeKey].Key == key)
            {
                return node.Entries[maybeKey];
            }
            else
            {
                return null;
            }
        }
    }
    private int BinarySearch(List<Entry> entries , int key)
    {
        int low = 0;
        int max = entries.Count;
        int middle = 0;
        while (low <= max)
        {
            middle = (max + low) / 2;
            if (middle >= entries.Count)
            {
                return entries.Count - 1;
            }
            if (entries[middle].Key == key)
            {
                return middle;
            }
            else if (key > entries[middle].Key)
            {
                low = middle + 1;
            }
            else
            {
                max = middle - 1;
            }
        }
        return middle;
    }
    private int BinarySearch(List<Entry> entries, int key,ref int comparisons)
    {
        int low = 0;
        int max = entries.Count;
        int middle = 0;
        while (low <= max)
        {
            middle = (max + low) / 2;
            if (middle >= entries.Count)
            {
                return entries.Count - 1;
            }
            if (entries[middle].Key == key)
            {
                return middle;
            }
            else if (key > entries[middle].Key)
            {
                low = middle + 1;
            }
            else
            {
                max = middle - 1;
            }
            comparisons++;
        }
        return middle;
    }

    private void SplitChild(Node parentNode, int nodeToBeSplitIndex, Node nodeToBeSplit)
{
    var newNode = new Node(this.Degree);

    parentNode.Entries.Insert(nodeToBeSplitIndex, nodeToBeSplit.Entries[this.Degree - 1]);
    parentNode.Children.Insert(nodeToBeSplitIndex + 1, newNode);

    newNode.Entries.AddRange(nodeToBeSplit.Entries.GetRange(this.Degree, this.Degree - 1));

    nodeToBeSplit.Entries.RemoveRange(this.Degree - 1, this.Degree);

    if (!nodeToBeSplit.IsLeaf)
    {
        newNode.Children.AddRange(nodeToBeSplit.Children.GetRange(this.Degree, this.Degree));
        nodeToBeSplit.Children.RemoveRange(this.Degree, this.Degree);
    }
}

    private void InsertNonFull(Node node, int newKey, string newPointer)
    {
        int positionToInsert = node.Entries.TakeWhile(entry => newKey.CompareTo(entry.Key) >= 0).Count();

        if (node.IsLeaf)
        {
            node.Entries.Insert(positionToInsert, new Entry() { Key = newKey, Pointer = newPointer });
            return;
        }

        Node child = node.Children[positionToInsert];
        if (child.HasReachedMaxEntries)
        {
            this.SplitChild(node, positionToInsert, child);
            if (newKey.CompareTo(node.Entries[positionToInsert].Key) > 0)
            {
                positionToInsert++;
            }
        }

        this.InsertNonFull(node.Children[positionToInsert], newKey, newPointer);
    }
    private void Traverse(Node node, List<string> treeValues)
    {
        if (node.IsLeaf)
        {
            foreach (Entry entry in node.Entries)
            {
                treeValues.Add(entry.ToString());
            }
            return;
        }
        for (int i = 0; i < node.Children.Count; i++)
        {
            Traverse(node.Children[i], treeValues);
            if (i < node.Children.Count - 1)
            {
                treeValues.Add(node.Entries[i].ToString());
            }
        }
    }
    public List<string> TraverseCall()
    {
        List<string> treeValues = new List<string>();
        Traverse(Root, treeValues);
        return treeValues;
    }
    public void SaveTree()
    {
        List<string> treeValues = TraverseCall();
        using (StreamWriter streamWriter = new(SaveFilePath))
        {
            foreach (var values in treeValues)
            {
                streamWriter.WriteLine(values);
            }
        }
    }
    public void LoadTree()
    {
        using (StreamReader streamReader = new(SaveFilePath))
        {
            while (streamReader.EndOfStream == false)
            {
                string[] value = streamReader.ReadLine().Split(' ');
                Insert(int.Parse(value[0]), value[1]);
            }
        }
    }
}
    public class Node
    {
        private int degree;

        public Node(int degree)
        {
            this.degree = degree;
            this.Children = new List<Node>(degree);
            this.Entries = new List<Entry>(degree);
        }

        public List<Node> Children { get; set; }

        public List<Entry> Entries { get; set; }

        public bool IsLeaf
        {
            get
            {
                return this.Children.Count == 0;
            }
        }

        public bool HasReachedMaxEntries
        {
            get
            {
                return this.Entries.Count == (2 * this.degree) - 1;
            }
        }

        public bool HasReachedMinEntries
        {
            get
            {
                return this.Entries.Count == this.degree - 1;
            }
        }
    }
    public class Entry
    {
        public int Key { get; set; }

        public string Pointer { get; set; }

        public bool Equals(Entry other)
        {
            return this.Key.Equals(other.Key) && this.Pointer.Equals(other.Pointer);
        }
        public override string ToString()
        {
            return $"{Key} {Pointer}";
        }
    }
}