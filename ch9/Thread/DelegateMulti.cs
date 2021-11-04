using System;
public class CarDriver
{
    public static void start() { Console.WriteLine("집으로 출발 "); }
    public static void goForward() { Console.WriteLine("100미터 직진 "); }
    public static void goLeft() { Console.WriteLine("50미터 좌회전 "); }
    public static void goRight() { Console.WriteLine("70미터 우회전 "); }
    public static void arrive() { Console.WriteLine("집 도착 "); }
}

// 델리게이트에 등록된 순서대로 동작, 시간차를 제어할 수 없음
public delegate void goHome();

namespace ch9_Thread
{
    
    public class DelegateMulti
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("메소드 따로 호출 ");
            //CarDriver.goLeft();
            //CarDriver.goForward();
            //CarDriver.goRight();
            //Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("[2] 대리자를 통한 메소드 등록 및 호출 ");
            goHome go = new goHome(CarDriver.start);
            go += new goHome(CarDriver.goLeft);
            go += new goHome(CarDriver.goForward);
            go += new goHome(CarDriver.goRight);
            go += new goHome(CarDriver.goLeft);
            go -= new goHome(CarDriver.goLeft);  // 대리자에 등록된 것 취소 
            go += new goHome(CarDriver.arrive);
            go();  // 대리자에 등록된 것 한 번에 호출
            Console.WriteLine();
            Console.WriteLine(" 대리자에 등록된 순서(시간차)를 바꿀 수 없기에 스레드 필요 ");
        }

    }
}
