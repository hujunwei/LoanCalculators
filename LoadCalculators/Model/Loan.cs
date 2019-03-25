namespace LoadCalculators.Model
{
    public class Loan
    {
        public string LoanName;
        public double? Principal;
        public double? Rate;
        public double? FixedPayEveryMonth;
        public double? MonthsPaid;

        public Loan DeepCopy()
        {
            return new Loan
            {
                LoanName = LoanName,
                Principal = Principal,
                Rate = Rate,
                FixedPayEveryMonth = FixedPayEveryMonth,
                MonthsPaid = MonthsPaid
            };
        }
    }
}
