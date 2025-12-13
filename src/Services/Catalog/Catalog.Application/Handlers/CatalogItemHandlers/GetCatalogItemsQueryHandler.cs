

namespace Catalog.Application.Handlers.CatalogItemHandlers;

public class GetCatalogItemsQueryHandler(ICatalogItemRepository catalog) 
    : IRequestHandler<GetCatalogItemsQuery, GetCatalogItemsResult>
{
    public async Task<GetCatalogItemsResult> Handle(GetCatalogItemsQuery query, CancellationToken ct)
    {
        var items = await catalog.GetAllCatalogItemsAsync();
        return new GetCatalogItemsResult(items);
    }
}