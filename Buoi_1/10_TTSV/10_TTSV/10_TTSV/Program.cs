using System;

namespace _TTSV
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write(Environment.NewLine);
                Console.Write("Nhap ma sinh vien: ");
                string mssv = Console.ReadLine();

                Console.Write("Nhap ho ten sinh vien: ");
                string hoten = Console.ReadLine();

                Console.Write("Nhap diem toan: ");
                double diemtoan = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhap diem ly: ");
                double diemly = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhap diem hoa: ");
                double diemhoa = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Thong tin vua nhap: ");
                Console.WriteLine("Ma so sinh vien: " + mssv);
                Console.WriteLine("Ho ten: " + hoten);
                Console.WriteLine("Diem toan:" + diemtoan);
                Console.WriteLine("Diem ly: " + diemly);
                Console.WriteLine("Diem hoa:" + diemhoa);
                Console.Write(Environment.NewLine);
            }
           

        }
    }
}
