namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<GetBrandsResult>> GetBrand()
        {
            return await mediator.Send(new GetBrandsQuery());
        }
    }
}
