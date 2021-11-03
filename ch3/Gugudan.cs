using System;
namespace ch3
{
    public class Gugudan
    {
        public static void Main(string[] args)
        {
            //for(int i=2; i<10; i++)
            //{
            //    for(int j=1; j<10; j++) {
            //        Console.WriteLine("{0} * {1} = {2:D2} ", i, j, i*j);
            //    }
            //    Console.WriteLine("");
            //}


            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 2; j < 10; j++)
            //    {
            //        Console.Write("{0} * {1} = {2:D2}   ", j, i, i * j);
            //    }
            //    Console.WriteLine("");
            //}


            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write("{0} * {1} = {2:D2}    ", i, j, i * j);
            //    }
            //    Console.WriteLine("");
            //}



            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write("{0} * {1} = {2:D2}   ", i, j, i * j);
                }
                Console.WriteLine("");
            }


            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 4; k++)
                    {
                        Console.Write("{0} * {1} = {2:D2}   ", k, j, k * j);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
        }
    }
}
