using System;

namespace _KTCL
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a % 2 == 0)
            {
                Console.Write(a + " la so chan");
            }
            else
            {
                Console.Write(a + " la so le");
            }
            Console.ReadKey();
        }
    }
}
