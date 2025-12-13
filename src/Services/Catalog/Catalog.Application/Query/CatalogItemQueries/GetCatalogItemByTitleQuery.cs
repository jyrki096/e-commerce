namespace Catalog.Application.Query.CatalogItemQueries;

public record GetCatalogItemByTitleQuery(string title) : IRequest<GetCatalogItemByTitleResult>;