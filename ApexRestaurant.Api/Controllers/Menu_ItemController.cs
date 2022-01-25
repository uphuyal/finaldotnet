using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenu_Item;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
 [Route("api/menu_item")]
 public class Menu_ItemController : ControllerBase
 {
 private readonly IMenu_ItemService _menu_itemServices;
 public Menu_ItemController(IMenu_ItemService menu_itemService)
 {
 _menu_itemServices = menu_itemService;
 }
 [HttpGet]
 [Route("{id}")]
 public IActionResult Get([FromRoute] int id)
 {
 var menu_item = _menu_itemServices.GetById(id);
 if (menu_item == null)
 return NotFound();
 return Ok(menu_item);
 }
 [HttpGet]
 [Route("")]
 public IActionResult GetAll()
 {
 var menu_items = _menu_itemServices.GetAll();
 return Ok(menu_items);
 }
 [HttpPost]
 [Route("")]
 public IActionResult Post([FromBody] Menu_Item model)
 {
 _menu_itemServices.Insert(model);
return Ok();
 }
 [HttpPut]
 [Route("")]
 public IActionResult Put([FromBody] Menu_Item model)
 {
 _menu_itemServices.Update(model);
 return Ok();
 }
 [HttpDelete]
 [Route("")]
 public IActionResult Delete([FromBody] Menu_Item model)
 {
 _menu_itemServices.Delete(model);
 return Ok();
 }
 }
}