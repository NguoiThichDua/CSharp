using System;

namespace _SNT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int bien_dem = 0;
            Console.Write("Nhap mot so nguyen: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
                if (a % i == 0)
                    bien_dem++;

            if (bien_dem == 2)
                Console.WriteLine(a + " la so nguyen to.");
            else
                Console.WriteLine(a + " khong phai la so nguyen to.");

            Console.ReadKey();
        }
    }
}
