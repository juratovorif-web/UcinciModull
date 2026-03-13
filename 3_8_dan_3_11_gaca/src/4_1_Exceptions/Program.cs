namespace _4_1_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Thread thread1 = new Thread(Do1);
            thread1.Start();
            Thread thread2 = new Thread(Do2);
            thread2.Start();
            
           
        }
        static void Do1()
        {
            for (int i = 1; i <= 10; i++)
            {
               Console.WriteLine("Hello");
            }
        }
        static void Do2()
        {
            for (int i = 1; i <= 10; i++)
            {
               Console.WriteLine("Word");
            }
        }
                

    }
       


}


       


                   
            
               
              




          
