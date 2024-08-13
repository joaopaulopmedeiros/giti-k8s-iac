namespace Purchase.Api.Services;

public class PurchaseService 
{
    public async Task<IEnumerable<PurchaseSearchResponse>> SearchAsync() 
    {
        await Task.Delay(100);
        return [];
    }
}