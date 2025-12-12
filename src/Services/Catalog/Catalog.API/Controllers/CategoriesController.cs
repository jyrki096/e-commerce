



namespace Catalog.API.Controllers
{
    public class CategoriesController : ApiController
    {
        [HttpGet]
        [ProducesResponseType(typeof(GetCategoriesResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetCategoriesResult>> GetCategories()
        {
            return Ok(await Mediator.Send(new GetCategoriesQuery()));
        }
    }
}
