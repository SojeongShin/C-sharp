using System;

delegate void SimpleDelegate1();  // 매개변수가 없는 델리게이트 생성
delegate void SimpleDelegate2(int i);  // 매개변수가 하나인 델리게이트

class aaaa  // 선언된 델리게이트 -> 호출할 메소드 반드시 필요
{
    public void Gun()
    {
        Console.WriteLine("총알 발사 Gun");
    }
    public void Missile(int x)
    {
        Console.WriteLine("미사일 {0}개 발사 ", x);
    }
}

namespace ch9_Thread
{
    class Delegate
    {
        static void Main(string[] args)
        {
            aaaa dele = new aaaa();  // aaaa 클래스의 인스턴스 dele 생성
            // s1 델리게이트 인스턴스 생성 
            SimpleDelegate1 s1 = new SimpleDelegate1(dele.Gun);
            // s2 델리게이트 인스턴스 생성
            SimpleDelegate2 s2 = new SimpleDelegate2(dele.Missile);

            s1();
            s2(3);
        }
    }
}
