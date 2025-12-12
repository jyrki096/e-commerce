



namespace Catalog.API.Controllers
{
    public class CategoriesController : ApiController
    {
        [HttpGet]
        [ProducesResponseType(typeof(GetBrandsResult), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetBrandsResult>> GetCategories()
        {
            return Ok(await Mediator.Send(new GetCategoriesQuery()));
        }
    }
}
