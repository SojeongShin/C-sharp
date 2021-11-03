using System;

namespace ssj581
{
    class 문제1 
    {
        static void Main(string[] args)
        {
            Console.Write("택시로 이동 할 거리(KM)를 입력하세요 : ");
            int distance =Convert.ToInt32(Console.ReadLine());

            Taxi t = new Taxi(distance);
            t.Distance = distance;
            Taxi.Taxi(t.Distance);
        }
    }

    public class Taxi : iCalc
    {
        private int _Distance;  // 이동거리

        public Taxi(int distance) 
        {
            Console.WriteLine("이동거리 {0} KM는 {1}이고", distance, MileTransform());
            Console.WriteLine("택시요금은 {0}원 이다.", Money());
        }

        public int Distance
        {
            get { return _Distance; }
            set { _Distance = value; }
        }

        public int Money()
        {
            return 2000 * _Distance / 100 * 110;  // 부가세 10퍼센트 

        }

        public double MileTransform()
        {
            return _Distance / 8 * 5;  // 1마일 = 1.6키로 
        
        }
    }

    public interface iCalc
    {
        public int Money();
        double MileTransform();
    }
}
