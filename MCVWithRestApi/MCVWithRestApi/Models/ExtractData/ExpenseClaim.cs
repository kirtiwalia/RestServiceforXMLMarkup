namespace MCVAppWithRestApi.Models.ExtractData
{
    public class ExpenseClaim
    {
        public string CostCentre { get; set; }

        public double TotalExpense { get; set; }

        public string PaymentMethod { get; set; }

        public double TotalExcludingGST { get; set; }

        public double GSTApplied { get; set; }
        
    }
}