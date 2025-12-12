namespace Catalog.Infrastructure.Repositories;

public class CategoryRepository(IDocumentSession session) : IBrandRepository, ICategoryRepository,ICatalogItemRepository
{
    public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
    {
        return await session.Query<Brand>().ToListAsync();
    }

    public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
    {
        return await session.Query<Category>().ToListAsync();
    }
    
    public async Task<CatalogItem?> GetCatalogItemByIdAsync(Guid id)
    {
        return await session.LoadAsync<CatalogItem>(id);
    }

    public async Task<IEnumerable<CatalogItem>> GetCatalogItemByTitleAsync(string title)
    {
        return await session.Query<CatalogItem>()
            .Where(item => !string.IsNullOrEmpty(item.Title)
                                              && item.Brand.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
            .ToListAsync();
    }

    public async Task<IEnumerable<CatalogItem>> GetCatalogItemByBrandAsync(string brandTitle)
    {
        return await session.Query<CatalogItem>()
            .Where(item => item.Brand != null && !string.IsNullOrEmpty(item.Brand.Title)
                                              && item.Brand.Title.Contains(brandTitle, StringComparison.OrdinalIgnoreCase))
            .ToListAsync();
    }

    public async Task<CatalogItem> CreateCatalogItemAsync(CatalogItem item)
    {
        session.Store(item);
        await session.SaveChangesAsync();
        return item;
    }

    public async Task<IEnumerable<CatalogItem>> GetAllCatalogItemsAsync()
    {
        return await session.Query<CatalogItem>().ToListAsync();
    }

    public async Task<bool> UpdateCatalogItemAsync(CatalogItem item)
    {
        session.Store(item);
        await session.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteCatalogItemAsync(Guid id)
    {
        session.Delete<CatalogItem>(id);
        await session.SaveChangesAsync();
        return true;
    }
}