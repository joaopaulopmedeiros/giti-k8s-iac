namespace Purchase.Api.Requests;

public class PurchaseSearchRequest : PagedRequest
{
    public DateTime? CreatedAt { get; set; }
}