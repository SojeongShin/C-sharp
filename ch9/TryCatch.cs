using System;

namespace ch9
{
    class Trycatch
    {
        static void Main(string[] args)
        {
            int i = 3; int j = 0; int k = 0;

            try  // 에러 의심 구문 입력
            {
                k = i / j;
            }
            catch(Exception e)  // 에러가 발생하면 처리해야 하는 코드 입력 
            {
                Console.WriteLine("에러가 발생 - 사람이 알려주는 메시지 ");
                Console.WriteLine(e.Message);
            }
            finally  // 에러 발생 여부와 관계없이 무조건 출력하는 문장
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
            Console.WriteLine(k);
        }
    }
}
