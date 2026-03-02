namespace _3_9_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eng katta sonni cqarad
            //ArrayList list = new ArrayList() { 4,2,6,8,7,2,5,9,88 };

            //var max = (int)list[0];
            //foreach(var item in list)
            //{
            //    var num = (int)item;
            //    if(num > max)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine(max);


            // Xamma sonni qowb beradi
            //ArrayList list = new ArrayList() { 14,45,17,42 };
            // var res = 0;
            // foreach (var item in list)
            // {
            //     res += (int)item;
            // }
            // Console.WriteLine(res);

            // - 1
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //arrayList.Add(5);
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            // - 2
            //ArrayList list = new ArrayList() { 4,8,7,9,6};
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            // - 4
            //ArrayList list = new ArrayList() { 4, 8, 7, 9, 6 };
            //for(var i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[2]);
            //    break;
            //}

            // - 5
            //ArrayList list = new ArrayList() { "nma", "gap" };
            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            // - 6
            //ArrayList list = new ArrayList() { "qwer","contains","hmwrk"};
            //var res = false;
            //foreach(var item in list)
            //{
            //    if(item.ToString() == "s")
            //    {
            //       res = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(res);

            // - 7
            //ArrayList arrayList = new ArrayList() { "lls","sss","aaa" };
            //arrayList.Remove("lls");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            // - 8
            //ArrayList listt = new ArrayList() { "lls", "sss", "aaa" };
            //listt.Clear();
            //foreach (var item in listt)
            //{
            //    Console.WriteLine(item);
            //}

            // - 9
            //ArrayList list = new ArrayList();
            //for(var i = 1; i <= 10;  i++)
            //{
            //    list.Add(i);
            //}
            //foreach(var i in list)
            //{
            //    Console.WriteLine(i);
            //}

            // 10
            //ArrayList list = new ArrayList() { 1,5,4,7,8,6};
            //for (var i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            // 11
            //ArrayList list = new ArrayList() { 1, 5, 4, 7, 8, 6 };
            //var res = 0;
            //foreach (var item in list) 
            //{
            //    res += (int)item;   
            //}
            //Console.WriteLine(res);

            // 12
            //ArrayList list = new ArrayList() { 1, 5, 4, 7, 8, 6 };
            //var max = (int)list[0];
            //foreach (var item in list) 
            //{
            //    var num = (int)item;
            //    if(num > max)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine(max);

            // 28
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddLast(14);
            //list.AddLast(27);
            //list.AddLast(34);
            //bool res = list.Contains(237);
            //Console.WriteLine(res);

            // 29
            //LinkedList<int> ints = new LinkedList<int>();
            //ints.AddLast(1);
            //ints.AddLast(2);
            //ints.AddLast(3);
            //ints.AddLast(4);
            //ints.AddLast(5);
            //for(LinkedListNode<int> node = ints.Last; node != null; node = node.Previous)
            //{
            //    Console.WriteLine(node.Value);
            //}

            //30
            LinkedList<int> ints = new LinkedList<int>();
            ints.AddLast(1);
            ints.AddLast(2);
            ints.AddLast(3);
            ints.AddLast(4);
            ints.AddLast(5);
            var res = 0;
            foreach (int i in ints)
            {
               Console.WriteLine(res += i);
            }
               

        }

    }
}
