namespace Catalog.Application.Handlers.BrandHandlers;

public class GetBrandsQueryHandler(IBrandRepository brandRepository) : IRequestHandler<GetBrandsQuery, GetBrandsResult>
{
    public async Task<GetBrandsResult> Handle(GetBrandsQuery query, CancellationToken cancellationToken)
    {
        IEnumerable<Brand> brandList = await brandRepository.GetAllBrandsAsync();
        return new GetBrandsResult(brandList);
    }
}