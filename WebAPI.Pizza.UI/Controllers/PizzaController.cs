using Microsoft.AspNetCore.Mvc;
using WebAPI.Pizza.Ui.Interface.Repository;
using WebAPI.Pizza.UI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Pizza.UI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        #region propriété
        private readonly IPizzaRepository _repository;
        #endregion

        /// <summary>
        /// Constructeur - il va falloir mettre en place un système de connection sur API
        /// </summary>
        /// <param name="repository"></param>
        public PizzaController(IPizzaRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<WebAPI.Pizza.UI.Models.Pizza> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// ajout d'une nouvelle recette de pizza dans la base
        /// -- vérification pour l'ajout des ingredients
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult AddPizza([FromBody] WebAPI.Pizza.UI.Models.Pizza pizza)
        {
            IActionResult result = this.BadRequest("Mauvaise requète envoyé.");
            if (pizza is not null && pizza.Id == 0 && ModelState.IsValid) // ajout dans la base
            {
                try
                {
                    var piz = _repository.Add(pizza);
                    if (_repository.SaveChanges() > 0)
                        result = this.Ok(piz);
                    else result = this.Problem("Problème lors de l'ajout");
                }
                catch
                {
                    result = this.Problem("Problème lors de l'ajout.");
                }
            }

            return result;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
