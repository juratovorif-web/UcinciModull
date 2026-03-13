using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_11_dars.NodePractice.NodePractice;

public class Node
{
    public int Value;
    public Node Next;

    public Node(int value = 0)
    {
        Value = value;
        Next = null;
    }
}

