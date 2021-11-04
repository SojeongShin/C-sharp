using System;
using System.Threading;

namespace ch9_Thread
{
    public class Thread_sleep
    {
        static Thread th_a = new Thread(FuncA);
        static Thread th_b = new Thread(FuncB);

        static void FuncA()
        {
            for(int i=0; i<10; i++)
            {
                System.Threading.Thread.Sleep(3000);  // 1000이 1초
                Console.WriteLine("A:Count = " +i);
            }
        }
        static void FuncB()  // 스레드 몸체 작성 - 메소드 2
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("B:Count= " + i);
            }
        }
        public static void Main(string[] args)
        {
            th_a = new Thread(FuncA);
            th_b = new Thread(FuncB);

            th_a.Start();
            th_b.Start();
        }
    }
}
