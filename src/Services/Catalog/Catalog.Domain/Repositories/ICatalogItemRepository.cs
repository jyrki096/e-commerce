namespace Catalog.Domain.Repositories;

public interface ICatalogItemRepository
{
    Task<CatalogItem> CreateCatalogItemAsync(CatalogItem item);
    Task<IEnumerable<CatalogItem>> GetAllCatalogItemsAsync();
    Task<CatalogItem?>  GetCatalogItemByIdAsync(Guid id);
    Task<IEnumerable<CatalogItem>> GetCatalogItemByTitleAsync(string title);
    Task<IEnumerable<CatalogItem>> GetCatalogItemByBrandAsync(string brandTitle);
    Task<bool> UpdateCatalogItemAsync(CatalogItem item);
    Task<bool> DeleteCatalogItemAsync(Guid id);
}