using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Pizza.Ui.Infrastructure.Database;
using WebAPI.Pizza.Ui.Infrastructure.DataLayer;
using WebAPI.Pizza.UI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Pizza.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IngredientDataLayer _dataLayer;

        public IngredientController(PizzaDbContext dbContext)
        {
            _dataLayer = new IngredientDataLayer(dbContext);
        }

        // GET: api/<IngredientController>
        [HttpGet]
        public IEnumerable<Ingredient> Get()
        {
            return _dataLayer.GetAll();
        }

        // GET api/<IngredientController>/5
        [HttpGet("{id}")]
        public Ingredient? Get(int id)
        {
            return _dataLayer.GetById(id);
        }

        // POST api/<IngredientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IngredientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IngredientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
