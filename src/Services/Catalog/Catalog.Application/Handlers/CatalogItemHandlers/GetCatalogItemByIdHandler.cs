namespace Catalog.Application.Handlers.CatalogItemHandlers;

public class GetCatalogItemByIdHandler(ICatalogItemRepository catalogItemRepository) : IRequestHandler<GetCatalogItemByIdQuery, GetCatalogItemByIdResult>
{
    public async Task<GetCatalogItemByIdResult> Handle(GetCatalogItemByIdQuery query, CancellationToken cancellationToken)
    {
        var item = await catalogItemRepository.GetCatalogItemByIdAsync(query.id);
        return new GetCatalogItemByIdResult(item);
    }
}