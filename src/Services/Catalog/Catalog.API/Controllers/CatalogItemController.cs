using Catalog.Application.Commands.CatalogItemCommands;

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
        
        [HttpGet("brand/{brandTitle}")]
        [ProducesResponseType(typeof(GetCatalogItemByBrandTitleResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetCatalogItemByBrandTitleResult>> GetByBrandTitle(string brandTitle)
        {
            return Ok(await Mediator.Send(new GetCatalogItemByTitleQuery(brandTitle)));
        }
        
        [HttpPost]
        [ProducesResponseType(typeof(CreateCatalogItemResult), (int)HttpStatusCode.Created)]
        public async Task<ActionResult<CreateCatalogItemResult>> CreateCatalogItem(
            [FromBody] CreateCatalogItemCommand command)
        {
            var result = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }
    }
}
