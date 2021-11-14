using System;
namespace ch3
{
    public class 가위바위보
    {
        public static void Main(string[] args)
        {
            int manSu = 0; int cnt = 0; int ga = 0; int ba = 0; int bo = 0;
            int win = 0; int lose = 0; int same = 0;  // 나의 기준 승패

            while (true)
            {
                Random num = new Random();
                int comSu = num.Next(1, 4);

                Console.Write("1, 2, 3중 하나의 수 입력: ");
                manSu = Convert.ToInt32(Console.ReadLine());

                if (manSu == -1) break; cnt++;

                string result = checkResult(manSu, comSu);  // 게임 실행 결과 메소드
                Console.WriteLine(result);
                Console.WriteLine("컴의 선택은 {0}", comSu);
                Console.WriteLine("-----------------------");

                comCnt(ref ga, ref ba, ref bo, comSu); // 컴퓨터 랜덤수 카운트
                myCnt(ref win, ref lose, ref same, result);  // 내가 승,패,무 한 횟수 
            }

            Console.WriteLine("총 게임 횟수 {0}", cnt);
            Console.WriteLine("컴의 가위= {0}, 컴의 바위= {1}, 컴의 보= {2}", ga, ba, bo);
            Console.WriteLine("서로 비김= {0}, 내가 승= {1}, 내가 패= {2}", same, win, lose);
        }

        private static string checkResult(int manSu, int comSu)
        {
            string win = "내가 승";
            string lose = "내가 패";
            string same = "서로 비김";
            string res;

            if (manSu == 1)
            {
                if (comSu == 1) res = same;
                else if (comSu == 2) res = lose;
                else return res = win;
            }
            else if (manSu == 2)
            {
                if (comSu == 1) res = win;
                else if (comSu == 2) res = same;
                else return res = lose;
            }
            else
            {
                if (comSu == 1) res = lose;
                else if (comSu == 2) res = win;
                else res = same;
            }
            return res;
        }

        private static void comCnt(ref int ga, ref int ba, ref int bo, int comSu)
        {
            if (comSu == 1) ga += 1;
            else if (comSu == 2) ba += 1;
            else bo += 1;
        }

        private static void myCnt(ref int win, ref int lose, ref int same, string result)
        {
            if (result == "내가 승") win++;
            else if (result == "내가 패") lose++;
            else same++;
        }
    }
}
