using System.Net;

namespace Catalog.API.Controllers
{
    public class BrandsController : ApiController
    {
        [HttpGet]
        [ProducesResponseType(typeof(GetBrandsResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetBrandsResult>> GetBrand()
        {
            return Ok(await Mediator.Send(new GetBrandsQuery()));
        }
    }
}
