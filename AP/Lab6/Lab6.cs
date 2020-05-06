using System;

namespace AP.Lab6
{
    public class Lab6
    {
        public static void Main(string[] args)
        {
            int choose;
            do
            {
                ShowMenu();
                choose = ReadNumber();
                if (choose > 0 && choose < 5)
                {
                    Console.WriteLine("Nhap so thu nhat: ");
                    int no1 = ReadNumber();
                    Console.WriteLine("Nhap so thu hai: ");
                    int no2 = ReadNumber();
                    MathNumber mn = Calc.GetFunction(choose);
                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("Tong 2 so: " + mn(no1, no2));
                            break;
                        case 2:
                            Console.WriteLine("Hieu 2 so: " + mn(no1, no2));
                            break;
                        case 3:
                            Console.WriteLine("Tich 2 so: " + mn(no1, no2));
                            break;
                        case 4:
                            Console.WriteLine("Thuong 2 so: " + mn(no1, no2));
                            break;
                    }
                }
            } while (choose != 0);
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Lua chon chuc nang: ");
            Console.WriteLine("1. Tong");
            Console.WriteLine("2. Hieu");
            Console.WriteLine("3. Tich");
            Console.WriteLine("4. Thuong");
            Console.WriteLine("0. Thoat Chuong Trinh");
        }

        public static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}