using System;
namespace ch3
{
    public class For_star
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }



            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}
