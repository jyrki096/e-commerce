namespace Catalog.Application.Query.CatalogItemQueries;

public record GetCatalogItemByBrandTitleQuery(string BrandTitle) : IRequest<GetCatalogItemByBrandTitleResult>;