namespace Catalog.Application.Query.CatalogItemQueries;

public record GetCatalogItemByIdQuery(Guid id) : IRequest<GetCatalogItemByIdResult>;