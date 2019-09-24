using System;

namespace _SNT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap So N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            /* Cau A */
            Console.Write("a)");
            Console.Write(Environment.NewLine);
            Console.Write("Cac so <= n: ");

            int TongA = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + " ");
                TongA += i; 
            }
            Console.Write(Environment.NewLine);
            Console.Write("Tong cac so nguyen <= " + n + " la: " + TongA);
            Console.Write(Environment.NewLine);

            /* Cau B */
            Console.Write("b)");
            Console.Write(Environment.NewLine);
            int TongB = 0;
            Console.Write("Cac so chan <= n: ");
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    TongB += i;
                }
            }
            Console.Write(Environment.NewLine);
            Console.Write("Tong cac so nguyen chan <= " + n + " la: " + TongB);
            Console.Write(Environment.NewLine);

            /* Cau C */
            Console.Write("c)");
            Console.Write(Environment.NewLine);
            int TongC = 0;
            Console.Write("Cac so le <= n: ");
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                    TongC += i;
                }
            }
            Console.Write(Environment.NewLine);
            Console.Write("Tong cac so nguyen le <= " + n + " la: " + TongC);
            Console.Write(Environment.NewLine);

            /* Cau D*/
            Console.Write("d)");
            Console.Write(Environment.NewLine);

            int TongD = 0;
            int bien_dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    bien_dem++;
                }
               
            }

            if (bien_dem == 2)
                TongD += bien_dem;
                Console.Write("Tong cac so nguyen to la: " + TongD);

            Console.ReadKey();
        }
    }
}
