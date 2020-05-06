using System;

namespace AP.Session6
{
    //khai bao 1 delegate tra ve int va cos 2 tham so intvvvvvvvvvvvvvvvvvv
    public delegate int IntegerToInteger(int a, int b);

    public class Program
    {
        public static void Main1(string[] args)
        {
            // tao doi tuong delegate
            IntegerToInteger ii = new IntegerToInteger(Calculator.Add);
            ii += Calculator.Subtract; // nap them ham vao chuoi thuc hien cura delegate - multi catch
            ii += new Calculator().division;
            ii(15, 5); // thuc thi cac ham duoc nap vao delegate

            //Console.WriteLine("a =" + a);

            //Calculator.Add(2, 5);
            //Calculator.Subtract(2, 5);
            //luon can chay 2 dong voi moi cap so
            TaxMoney tm = TaxCalc.GetTax("VN"); //tm la delegate
            float tax = tm(1000000000);
            Console.WriteLine("Thue phai nop: " + tax);

            //Tao 1 ham an danh bang delegate
            TaxMoney tm2 = delegate(float salary) { return salary * 40 / 100; };
            float frTax = tm2(10000);
            Console.WriteLine("Thue tai Phap: " + frTax);
        }
    }
}