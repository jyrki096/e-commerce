namespace Catalog.Infrastructure.Data;

public class InitializeDatabaseAsync : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken ct)
    {
        using var session = store.LightweightSession();

        if (!await session.Query<Brand>().AnyAsync())
        {
            session.Store<Brand>(InitialData.Brands);
            await session.SaveChangesAsync(ct);
        }
        else
        {
            var brands = await session.Query<Brand>().ToListAsync(ct);

            var res = brands;
        }

        foreach (var category in InitialData.Categories)
        {
            if (!session.Query<Category>().Any(c => c.Id == category.Id))
            {
                session.Store(category);
            }
        }
        
        foreach (var item in InitialData.CatalogItems)
        {
            if (!session.Query<CatalogItem>().Any(c => c.Id == item.Id))
            {
                session.Store(item);
            }
        }
        
        await session.SaveChangesAsync(ct);
    }
}