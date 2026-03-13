using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_11_dars.NodePractice.NodePractice;

public class NodeService
{
    public static Node CreateNode(int[] value)
    {
       
        Node headNode = new Node(value[0]);
        Node currentNode = headNode;

        for (int i = 1; i < value.Length; i++)
        {
            Node newNode = new Node(value[i]);
            currentNode.Next = newNode;
            currentNode = currentNode.Next;
        }

        return headNode;
    }
}
