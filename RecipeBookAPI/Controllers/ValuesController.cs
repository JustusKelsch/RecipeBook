using Microsoft.AspNetCore.Mvc;
using RecipeBookLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeBookAPI.Controllers {
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        RecipeModel recipe = new RecipeModel {
            RecipeName = "Test",
            Ingredients = [new IngredientModel {
                    Amount = 1,
                    Measurement = "Cup",
                    Ingredient = "Flour"
                },
                new IngredientModel {
                    Amount = 3,
                    Measurement = "Cups",
                    Ingredient = "Water"
                },
            ],
            Directions = ["Cook", "Eat"]
        };
        List<RecipeModel> recipes = new List<RecipeModel>();
        
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<RecipeModel> Get() {
            recipes.Add(recipe);
            return recipes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public int Get(int id) {
            return id;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value) {
            recipes.Add(recipe);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
