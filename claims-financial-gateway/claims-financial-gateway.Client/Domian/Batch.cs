namespace claims_financial_gateway.Client.Domian
{
    public class Batch
    {
        public int Id { get; set; }
        public DateTime RunDate { get; set; }
        public string BankName { get; set; } = "Test Name";
        public string BankDescription { get; set; } = "Test Description";
        public string BankAccountNumber { get; set; } = "Test Account Number";
        public CheckSummary? Check { get; set; }
        public ACHSummary? ACH { get; set; }
        public BatchStatus Status { get; set; }

        public class ACHSummary
        {
            public int TotalPayments { get; set; }
            public decimal TotalAmount { get; set; }
        }

        public class CheckSummary
        {
            public int TotalPayments { get; set; }
            public decimal TotalAmount { get; set; }
        }

        //TODO: Add Stuff
        public enum BatchStatus
        {
            Initilized,
            Printed,
            Completed,
            Errored
        }
    }
}
