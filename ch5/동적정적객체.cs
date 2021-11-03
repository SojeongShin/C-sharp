using System;

namespace ch5
{
    class Man
    {
        public static string name;   // 정적 메소드 
        public int age;          // 동적 메소드
        public float weight;   // static  삭제되면 메모리에서 사라짐
    } // 클래스 분리 


    class Program
    {
        static void Main(string[] args)
        { 
            {
                Man m1 = new Man();  // 인스턴스 객체 생성
                Man.name = "KBS";      // 객체 명으로 접근
                m1.age = 222;
                m1.weight = 55.5F;
                Console.WriteLine(" {0}, {1}, {2}", Man.name, m1.age, m1.weight);
            }

        }
    }
}
