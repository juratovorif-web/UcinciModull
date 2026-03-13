using _3_11_dars.NodePractice.NodePractice;

namespace _3_11_dars.NodePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 2, 3, 4, 5 };

            Node node = NodeService.CreateNode(nums);

            var res = GetSumOfNode(node);
            Console.WriteLine(res);


        }
        static int GetSumOfNode(Node node)
        {
            int sum = 0;

            while (node != null)
            {
                sum += node.Value;
                node = node.Next;
            }

            return sum;
        }
    }
}
