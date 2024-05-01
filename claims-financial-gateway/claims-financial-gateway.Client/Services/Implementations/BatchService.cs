using claims_financial_gateway.Client.Domian;
using claims_financial_gateway.Services.Interfaces;

namespace Services.Implementations
{
    public class BatchService : IBatchService
    {
        public Task<IList<Batch>> GetBatchesAsync()
        {
            IList<Batch> batches = [
                new() {
                    Id = 1,
                    RunDate = DateTime.Now.AddDays(-1),
                    Check = null,
                    ACH = new Batch.ACHSummary
                    {
                        TotalPayments = 344,
                        TotalAmount = 143.67M
                    },
                    Status = Batch.BatchStatus.Completed,
                },
                new()
                {
                    Id = 2,
                    RunDate = DateTime.Now,
                    Check = new Batch.CheckSummary
                    {
                        TotalPayments = 223,
                        TotalAmount = 23
                    },
                    ACH = null,
                    Status = Batch.BatchStatus.Errored,
                }
            ];

            return Task.FromResult(batches);
        }

        public Task<IList<Payment>> GetPaymentsAsync()
        {
            IList<Payment> payments = [ 
                    new Payment {
                        ClaimTransactionId = 1,
                        Payee = "Test Payee 1",
                        Address = "Test Payee Addres 1",
                        Amount = 500.25M
                    },
                    new Payment
                    {
                        ClaimTransactionId = 2,
                        Payee = "Test Payee 2",
                        Address = "Test Payee Address 2",
                        Amount = 500.25M
                    }
                ];

            return Task.FromResult(payments);
        }
    }
}
