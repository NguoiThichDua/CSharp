using System;

namespace _CVDTHT
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            const double pi = 3.14;
            Console.Write("Nhap Ban Kinh Duong Tron: ");
            double banKinh = Convert.ToDouble(Console.ReadLine());

            Console.Write(Environment.NewLine);

            Console.Write(string.Format("Chu vi hinh tron: ({0} * 2) * 3.14 = {1}", banKinh, (banKinh*2)*pi));

            Console.Write(Environment.NewLine);

            Console.Write(string.Format("Dien tich hinh tron: (3.14 * ({0} * {0}) = {1}", banKinh, pi* (banKinh*banKinh)));

            Console.ReadKey();
        }
    }
}
