using LoadCalculators.Model;
using System;

namespace LoadCalculators
{
    public class Program
    {
        static void Main(string[] args)
        {   
            /* Loan initializer */
            var loan = new Loan { LoanName = "Loan1", Principal = 528031.15, Rate = 4.5 / 100, FixedPayEveryMonth = 2700, MonthsPaid = 0 };
            var loan2 = new Loan { LoanName = "Loan2", Principal = 228031.15, Rate = 4.5 / 100, FixedPayEveryMonth = 2700, MonthsPaid = 0 };
            /* Loan calculation */
            var loanCalculator = new LoanCalculator();         
            var loanResult1 = loanCalculator.CalculateTotalInterest(loan);
            var loanResult2 = loanCalculator.CalculateTotalInterest(loan2);
            /* Loan Print */
            loanResult1.Print();
            loanResult2.Print();
            loanResult1.PrintMinus(loanResult2);

            Console.ReadKey();
        }
    }
}
