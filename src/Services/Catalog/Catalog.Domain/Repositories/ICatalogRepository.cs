namespace Catalog.Domain.Repositories;

public interface ICatalogRepository
{
    Task<IEnumerable<Category>> GetAllCategoriesAsync();
}