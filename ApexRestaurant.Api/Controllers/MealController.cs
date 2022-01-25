using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMeal;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
 [Route("api/meal")]
 public class MealController : ControllerBase
 {
 private readonly IMealService _mealsServices;
 public MealController(IMealService mealService)
 {
 _mealsServices = mealService;
 }
 [HttpGet]
 [Route("{id}")]
 public IActionResult Get([FromRoute] int id)
 {
 var meal = _mealsServices.GetById(id);
 if (meal == null)
 return NotFound();
 return Ok(meal);
 }
 [HttpGet]
 [Route("")]
 public IActionResult GetAll()
 {
 var meals = _mealsServices.GetAll();
 return Ok(meals);
 }
 [HttpPost]
 [Route("")]
 public IActionResult Post([FromBody] Meal model)
 {
 _mealsServices.Insert(model);
return Ok();
 }
 [HttpPut]
 [Route("")]
 public IActionResult Put([FromBody] Meal model)
 {
 _mealsServices.Update(model);
 return Ok();
 }
 [HttpDelete]
 [Route("")]
 public IActionResult Delete([FromBody] Meal model)
 {
 _mealsServices.Delete(model);
 return Ok();
 }
 }
}