namespace Purchase.Api.Responses;

public record PurchaseSearchResponse
(
    Guid Id,
    double Amount,
    DateTime CreatedAt,
    DateTime UpdatedAt
);