using System;
using CompoundInterestDLL;

namespace InterestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số tiền gốc (VND): ");
            double principal = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập lãi suất hàng năm (%): ");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập số năm: ");
            int years = int.Parse(Console.ReadLine());

            InterestCalculator calculator = new InterestCalculator();
            calculator.Principal = principal;
            calculator.Rate = rate;
            calculator.Years = years;

            string result = calculator.CalculateInterest();
            Console.WriteLine(result);  // Kết quả với dấu ấn

            Console.WriteLine("Luong Ngoc Nam");
            Console.ReadKey();
        }
    }
}