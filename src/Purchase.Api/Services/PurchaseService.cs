namespace Purchase.Api.Services;

public class PurchaseService 
{
    public async Task<IEnumerable<PurchaseSearchResponse>> SearchAsync(PurchaseSearchRequest request) 
    {
        await Task.Delay(100);
        
        PurchaseSearchResponse item = new() 
        {
            Id = Guid.NewGuid(),
            Amount = 100.00,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
        };
        
        return [item];
    }
}