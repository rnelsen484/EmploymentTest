using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_LinkedList
{
    public class RobertsLinkedList
    {
        /// <summary>
        /// Definition of Node
        /// </summary>
        public class Node
        {
             public Node nextNode = null;
             public object nodeData;
        }

        public Node FifthFromEndNode = null;

        private Node root = null;

        public Node First { get { return root; } }

        /// <summary>
        /// Empty the linked list of all nodes
        /// </summary>
        public void EmptyAll()
        {
            while (root != null)
            {
                Delete(root);
            }
        }

        /// <summary>
        /// Append Values to the linked list
        /// </summary>
        /// <param name="value"></param>
        public void AppendNew(object value)
        {
            Node n = new Node { nodeData = value };

            if (root == null)
            {
                root = n;
            }
            else
            {
                Last.nextNode = n;
            }
        }

        // Find the last node in the list
        public Node Last
        {
            get
            {
                Node curr = root;

                Node[] FiveLastNodes = new Node[5];

                if (curr == null)
                {
                    return null;
                }
                else
                {
                    // PUT ROOT NODE FIRST
                    FiveLastNodes[0] = root;
                }

                //////////////////////////////////////////
                // KEEP TRACK OF FIFTH FROM LAST HERE
                //////////////////////////////////////////

                int totalNodeCount = 1; // root already added

                while (curr.nextNode != null)
                {
                    // ITERATE TO NEXT NODE
                    curr = curr.nextNode;

                    // INSERT IN NODE LIST USING MODULO MATH

                    int index = totalNodeCount % 5;

                    FiveLastNodes[index] = curr;

                    // update total node count
                    totalNodeCount = totalNodeCount + 1;
                }

                // Update the fifth from last node here
                if (totalNodeCount >= 5)
                {
                    int indexFifthLast = (totalNodeCount - 5) % 5;

                    FifthFromEndNode = FiveLastNodes[indexFifthLast];
                }

                return curr;
            }
        }

        public void Delete(Node n)
        {
            if (root == n)
            {
                root = n.nextNode;
                n.nextNode = null;
            }
            else
            {
                Node curr = root;

                while (curr.nextNode != null)
                {
                    if (curr.nextNode == n)
                    {
                        curr.nextNode = n.nextNode;
                        n.nextNode = null;
                        break;
                    }
                    curr = curr.nextNode;
                }
            }
        }
    }
}
