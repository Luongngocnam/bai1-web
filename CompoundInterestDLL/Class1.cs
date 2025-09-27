using System;

namespace CompoundInterestDLL
{
    public class InterestCalculator
    {
        public double Principal { get; set; }  // Input: Số tiền gốc (VND)
        public double Rate { get; set; }      // Input: Lãi suất hàng năm (%)
        public int Years { get; set; }        // Input: Số năm

        public string CalculateInterest()
        {
            if (Principal <= 0 || Rate < 0 || Years <= 0)
            {
                return "Input không hợp lệ. Principal và Years phải lớn hơn 0, Rate không âm.";
            }

            double amount = Principal * Math.Pow(1 + (Rate / 100), Years);
            double interest = amount - Principal;
            string advice;

            if (Rate > 5)
            {
                advice = "Lãi suất tốt đấy!  luôn tăng trưởng thông minh!";
            }
            else
            {
                advice = "Cần đầu tư tốt hơn để không bao giờ lỗ!";
            }

            return string.Format("Lãi suất kép: {0:F2} VND. Tổng tiền: {1:F2} VND. Lời khuyên: {2}", interest, amount, advice);
        }
    }
}