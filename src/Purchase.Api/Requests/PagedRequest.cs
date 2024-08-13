namespace Purchase.Api.Requests;

public abstract class PagedRequest 
{
    public int Size { get; set; } = 10;
    public int Page { get; set; } = 1;
}
