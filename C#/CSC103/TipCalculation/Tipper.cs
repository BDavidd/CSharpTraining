namespace TipCalculation
{
    class Tipper
    {
        public double BillAmount;

        public double CalculateTip(double tipPercentage)
        {
            return BillAmount * tipPercentage;
        }

        public double CalculateTip()
        {
            return CalculateTip(0.15);
        }

        public double Divvy(int dinnerNumber)
        {
            return BillAmount / dinnerNumber;
        }
    }
}
