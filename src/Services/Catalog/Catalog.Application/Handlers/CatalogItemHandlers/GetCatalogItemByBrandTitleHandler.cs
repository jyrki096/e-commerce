namespace Catalog.Application.Handlers.CatalogItemHandlers;

public class GetCatalogItemByBrandTitleHandler(ICatalogItemRepository catalogItemRepository) 
    : IRequestHandler<GetCatalogItemByBrandTitleQuery, GetCatalogItemByBrandTitleResult>
{
    public async Task<GetCatalogItemByBrandTitleResult> Handle(
        GetCatalogItemByBrandTitleQuery query, CancellationToken ct)
    {
        var result = await catalogItemRepository.GetCatalogItemByBrandAsync(query.BrandTitle);
        return new GetCatalogItemByBrandTitleResult(result);
    }
}