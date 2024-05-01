namespace claims_financial_gateway.Client.Domian
{
    public class Payment
    {
        public int ClaimTransactionId { get; set; }
        public required string Payee { get; set; }
        public required string Address { get; set; }
        public decimal Amount { get; set; }
    }
}
