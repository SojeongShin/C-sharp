using System;
namespace ssj581
{
    public class 문제2
    {
        public static void Main(string[] args)
        {
            int remain;
            Console.Write("물건의 가격을 입력하세요(1000원 미만) : ");
            int won = Convert.ToInt32(Console.ReadLine());

            int total = 1000 - won;  // 거스름돈 총액

            int obeak = total / 500;  // 오백원짜리 갯수
            remain = total - obeak * 500;

            int beak = remain / 100;  // 백원짜리 갯수
            remain -= beak * 100;

            int osip = remain / 50;  // 오십원짜리 갯수
            remain -= osip * 50;  

            int sip = remain / 10;  // 십원짜리 갯수 
            remain -= sip * 10;

            int il = remain;

            Console.WriteLine("거스름돈 입니다.\n");
            Console.WriteLine("500원 {0} 개", obeak);
            Console.WriteLine("100원 {0} 개", beak);
            Console.WriteLine("50원 {0} 개", osip);
            Console.WriteLine("10원 {0} 개", sip);
            Console.WriteLine("1원 {0} 개", il);
            Console.WriteLine("거스름돈은 {0} 원 입니다.", total);
        }
    }
}
