using Microsoft.AspNetCore.Mvc;
using DrinksRepositoryLib;

namespace DrinksRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        public DrinksRepository _DrinksRepository { get; set; }

        public DrinksController(DrinksRepository drinksRepository)
        {
            _DrinksRepository = drinksRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        // GET: api/<DrinksController>
        [HttpGet]
        public ActionResult<IEnumerable<Drink>> Get()
        {
            IEnumerable<Drink> drinks = _DrinksRepository.GetAll();
            if (drinks.Any())
            {
                return Ok(drinks);
            }
            else
            {
                return NoContent();
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // GET api/<DrinksController>/5
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Drink> GetById([FromHeader] int id)
        {
            Drink? drink = _DrinksRepository.GetById(id);
            if (drink == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(drink);
            }
        }

        // POST api/<DrinksController>
        [HttpPost]
        public ActionResult<Drink> Post([FromBody] Drink newDrink)
        {
            try
            {
                Drink addedDrink = _DrinksRepository.Add(newDrink);
                return Created("/" + addedDrink.Id, addedDrink);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<DrinksController>/5
        [HttpPut("{id}")]
        public ActionResult<Drink> Put(int id, [FromBody] Drink updatedDrink)
        {
            Drink? result = _DrinksRepository.Update(id, updatedDrink);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // DELETE api/<DrinksController>/5
        [HttpDelete("{id}")]
        public ActionResult<Drink> Delete(int id)
        {
            Drink? removedDrink = _DrinksRepository.Remove(id);
            if (removedDrink == null)
            {
                return NotFound();
            }
            return Ok(removedDrink);
        }
    }
}
