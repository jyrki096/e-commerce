namespace Catalog.Application.DTO;

public record CreateCatalogItemDto(
    string? Title,
    string? ShortDescription,
    string? FullDescription,
    string? ImageUrl,
    Brand? Brand,
    Category? Category,
    decimal Price);