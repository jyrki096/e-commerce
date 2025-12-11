namespace Catalog.API.Controllers
{
    public class BrandsController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<GetBrandsResult>> GetBrand()
        {
            return await Mediator.Send(new GetBrandsQuery());
        }
    }
}
