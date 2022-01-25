using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMeal_Dishes;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
 [Route("api/meal_dishes")]
 public class Meal_DishesController : ControllerBase
 {
 private readonly IMeal_DishesService _meal_dishServices;
 public Meal_DishesController(IMeal_DishesService meal_dishService)
 {
 _meal_dishServices = meal_dishService;
 }
 [HttpGet]
 [Route("{id}")]
 public IActionResult Get([FromRoute] int id)
 {
 var meal_dish = _meal_dishServices.GetById(id);
 if (meal_dish == null)
 return NotFound();
 return Ok(meal_dish);
 }
 [HttpGet]
 [Route("")]
 public IActionResult GetAll()
 {
 var meals_dish = _meal_dishServices.GetAll();
 return Ok(meals_dish);
 }
 [HttpPost]
 [Route("")]
 public IActionResult Post([FromBody] Meal_Dishes model)
 {
 _meal_dishServices.Insert(model);
return Ok();
 }
 [HttpPut]
 [Route("")]
 public IActionResult Put([FromBody] Meal_Dishes model)
 {
 _meal_dishServices.Update(model);
 return Ok();
 }
 [HttpDelete]
 [Route("")]
 public IActionResult Delete([FromBody] Meal_Dishes model)
 {
 _meal_dishServices.Delete(model);
 return Ok();
 }
 }
}