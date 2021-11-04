using System;
using System.Threading;

namespace ch9_Thread
{
    public class Thread_start
    {
        static void Func_A()  // 스레드 몸체 작성 - 메소드 1
        {
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("A:Count= " +i);
            }
        }
        static void Func_B()  // 스레드 몸체 작성 - 메소드 2
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("B:Count= " + i);
            }
        }
        static void Func_C()  // 스레드 몸체 작성 - 메소드 3
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("C:Count= " + i);
            }
        }

        public static void Main(string[] args)
        {
            Thread th_a = new Thread(Func_A);
            Thread th_b = new Thread(Func_B);
            Thread th_c = new Thread(Func_C);
            th_a.Start();  // thread start
            th_b.Start();
            th_c.Start();
        }
    }
}
