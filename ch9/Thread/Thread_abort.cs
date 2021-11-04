using System;
using System.Threading;

namespace ch9_Thread
{
    public class Thread_abort
    {
        static Thread th_x = new Thread(FuncA);
        static Thread th_y = new Thread(FuncB);
        static void FuncA()
        {
            for(int i=0; i<10; i++)
            {
                if (i >= 3)  // FunA는 2까지만 출력 
                {
                    th_x.Abort();  // 해당 스레드 종료
                }
                Console.WriteLine("A:Count = " +i);
            }
        }
        static void FuncB()  // 스레드 몸체 작성 - 메소드 2
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("B:Count= " + i);
            }
        }

        public static void Main(string[] args)
        {
            th_x = new Thread(FuncA);
            th_y = new Thread(FuncB);
            th_x.Start();
            th_y.Start();
        }
    }
}
