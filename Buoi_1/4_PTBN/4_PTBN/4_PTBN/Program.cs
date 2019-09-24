using System;

namespace _PTBN
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write(Environment.NewLine);

            Console.Write("Phuong trinh ban vua nhap la: " + a + "x + " + b + " = 0");

            if (a == 0 )
            {
                Console.WriteLine("A phai khac 0");
            }
            else
            {
                Console.Write(Environment.NewLine);
                Console.Write("Phuong trinh co nghiem x = " + -b / a);
                Console.ReadKey();
            }
         }
    }
}
