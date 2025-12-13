namespace Catalog.API.Controllers
{
    public class CatalogItemController : ApiController
    {
        [HttpGet]
        [ProducesResponseType(typeof(GetCatalogItemsResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<GetCatalogItemsResult>>> GetAll()
        {
            return Ok(await Mediator.Send(new GetCatalogItemsQuery()));
        }
        
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetCatalogItemByIdResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetCatalogItemByIdResult>> GetById(Guid id)
        {
            return Ok(await Mediator.Send(new GetCatalogItemByIdQuery(id)));
        }
        
        [HttpGet("title/{catalogItemTitle}")]
        [ProducesResponseType(typeof(GetCatalogItemByTitleResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetCatalogItemByTitleResult>> GetByTitle(string catalogItemTitle)
        {
            return Ok(await Mediator.Send(new GetCatalogItemByTitleQuery(catalogItemTitle)));
        }
    }
}
