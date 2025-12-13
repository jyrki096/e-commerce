namespace Catalog.Application.Handlers.CatalogItemHandlers;

public class GetCatalogItemByTitleHandler(ICatalogItemRepository catalogItemRepository)
    : IRequestHandler<GetCatalogItemByTitleQuery, GetCatalogItemByTitleResult>
{
    public async Task<GetCatalogItemByTitleResult> Handle(GetCatalogItemByTitleQuery query, CancellationToken ct)
    {
        var result = await catalogItemRepository.GetCatalogItemByTitleAsync(query.title);
        return new GetCatalogItemByTitleResult(result);
    }
}