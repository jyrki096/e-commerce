

namespace Catalog.API.Controllers
{
    public class CatalogItemController : ApiController
    {
        [HttpGet]
        [ProducesResponseType(typeof(GetCatalogItemsResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<GetCatalogItemsResult>>> GetCatalogItems()
        {
            return Ok(await Mediator.Send(new GetCatalogItemsQuery()));
        }
    }
}
