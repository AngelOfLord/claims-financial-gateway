using claims_financial_gateway.Client.Domian;

namespace claims_financial_gateway.Services.Interfaces
{
    public interface IBatchService
    {
        Task<IList<Batch>> GetBatchesAsync();
        Task<IList<Payment>> GetPaymentsAsync();
    }
}