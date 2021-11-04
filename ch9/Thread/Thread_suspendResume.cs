using System;
using System.Threading;

namespace ch9_Thread
{
    public class Thread_suspendResume
    {
        static Thread th_a1 = new Thread(FuncA);
        static Thread th_b = new Thread(FuncB);

        static void FuncA()
        {
            for(int i=0; i<10; i++)
            {
                Thread.Sleep(3000);  // 3초 마다 동작 
                Console.WriteLine("A:Count = " +i);
                th_a1.Suspend();  // 한 번 실행하고 나서 얼음 됨 
            }
        }

        static void FuncB()
        {
            for(int i=0; i<10; i++)
            {
                Thread.Sleep(1000);  // 1초 마다 동작
                Console.WriteLine("B:Count = " +i);
            }
            th_a1.Resume();  // B 다 출력하고 A 깨워줌 
        }
        public static void Main(string[] args)
        {
            th_a1 = new Thread(FuncA);
            th_b = new Thread(FuncB);
            th_a1.Start();
            th_b.Start();
        }

    }
}
