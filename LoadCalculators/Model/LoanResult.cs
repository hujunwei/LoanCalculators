using System;

namespace LoadCalculators.Model
{
    public class LoanResult : Loan
    {
        public double? TotalInterestToPay { get; set; }
        public double? LeftMonthsToPay { get; set; }

        public void Print()
        {
            Console.WriteLine(Constants.ConsoleLineBreak);
            Console.WriteLine("LoanName >>" + LoanName);
            Console.WriteLine("Original Loan Amount (aka Principal) is: $" + Principal);
            Console.WriteLine("Original Loan Rate is: " + Rate * 100 + "%");
            Console.WriteLine("Original Loan FixedPayment every month is: $" + FixedPayEveryMonth);
            Console.WriteLine("Months Left to pay: " + LeftMonthsToPay + " Months");
            Console.WriteLine("Total Interest if pay with above months: $" + TotalInterestToPay);
            Console.WriteLine("Total Money you paid to bank: $" + (TotalInterestToPay + Principal));
            Console.WriteLine(Constants.ConsoleLineBreak);        
        }

        public void PrintMinus(LoanResult target)
        {
            if (target == null)
            {
                return;
            }
            Console.WriteLine(Constants.ConsoleLineBreak);
            Console.WriteLine("TotalInterest you save: $" + (TotalInterestToPay - target.TotalInterestToPay));
            Console.WriteLine("Months you save: " + (LeftMonthsToPay - target.LeftMonthsToPay) + " Months");
            Console.WriteLine(Constants.ConsoleLineBreak);
        }
    }
}
