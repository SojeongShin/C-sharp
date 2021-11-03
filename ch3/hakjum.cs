using System;
namespace ch3
{
    public class hakjum
    {
        public static void Main(string[] args)
        {
            int jumsu;
            string hakjum = " ";

            while(true)
            {
                Console.WriteLine("점수 입력: ");
                jumsu = Convert.ToInt16(Console.ReadLine());
                if (jumsu == -999) break;
                else if ((jumsu > 100) || (jumsu < 0))
                {
                    Console.WriteLine(" 점수를 재입력 하세요.");
                }

                //string hakjum = hakjumCalc(jumsu);  // 메소드 호출
                Console.WriteLine(hakjumCalc(jumsu, hakjum));
            }
        }
        private static string hakjumCalc(int jumsu, string hakjum)
        {
            string hakjumA = "학점은 A";
            string hakjumB = "학점은 B";
            string hakjumC = "학점은 C";
            string hakjumF = "학점은 F";

            switch (jumsu)
            {
                case >= 90:  hakjum = hakjumA;
                    break;

                case int n when (80 <= n && n < 90):
                    hakjum = hakjumB;
                    break;

                case int n when (70 <= n && n < 80):
                    hakjum = hakjumC;
                    break;

                case < 70: hakjum = hakjumF;
                    break;
            }
            return hakjum;
        }
    }
}
