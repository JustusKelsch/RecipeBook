using Microsoft.AspNetCore.Mvc;
using RecipeBookAPI.Models;
using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Xml.Linq;
using System.Collections.ObjectModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeBookAPI.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private readonly IConfiguration _configuration;
        private readonly string db = "Recipe_Book";
        public ValuesController(IConfiguration configuration) {
            _configuration = configuration;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<RecipeModel> Get() {
            List<RecipeModel> recipes;
            using (IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(db))) {
                recipes = connection.Query<RecipeModel>("dbo.spRecipes_GetAll").ToList();

                foreach (var recipe in recipes) {

                    var p = new DynamicParameters();
                    p.Add("@RecipeId", recipe.Id);
                    recipe.Ingredients = connection.Query<IngredientModel>("dbo.spIngredients_GetByRecipe", p, commandType: CommandType.StoredProcedure).ToList();

                }

                foreach (var recipe in recipes) {

                    var p = new DynamicParameters();
                    p.Add("@RecipeId", recipe.Id);
                    recipe.Directions = connection.Query<DirectionModel>("dbo.spDirections_GetByRecipe", p, commandType: CommandType.StoredProcedure).ToList();

                }
            }

            return recipes;
        }

        //    // GET api/<ValuesController>/5
        //    [HttpGet("{id}")]
        //    public int Get(int id) {
        //        return id;
        //    }

        //    // POST api/<ValuesController>
        //    [HttpPost]
        //    public void Post([FromBody] string value) {
        //        //recipes.Add(recipe);
        //    }

        //    // PUT api/<ValuesController>/5
        //    [HttpPut("{id}")]
        //    public void Put(int id, [FromBody] string value) {
        //    }

        //    // DELETE api/<ValuesController>/5
        //    [HttpDelete("{id}")]
        //    public void Delete(int id) {
        //    }
    }
}
