using LoadCalculators.Model;
namespace LoadCalculators
{
    public class LoanCalculator
    {
        public LoanResult CalculateTotalInterest(Loan loan)
        {
            var loanResult = InitializeLoanResult(loan);
            var tempLoan = loan.DeepCopy();

            while (tempLoan.Principal > 0)
            {
                var interestThisMonth = tempLoan.Principal * tempLoan.Rate / Constants.MonthsInYear;
                tempLoan.Principal -= (tempLoan.FixedPayEveryMonth - interestThisMonth);
                loanResult.TotalInterestToPay += interestThisMonth;
                loanResult.LeftMonthsToPay += 1;
            }

            return loanResult;
        }

        private LoanResult InitializeLoanResult(Loan loan)
        {
            return new LoanResult()
            {
                LoanName = loan.LoanName,
                Principal = loan.Principal,
                Rate = loan.Rate,
                FixedPayEveryMonth = loan.FixedPayEveryMonth,
                TotalInterestToPay = 0,
                LeftMonthsToPay = loan.MonthsPaid
            };
        }
    }
}
