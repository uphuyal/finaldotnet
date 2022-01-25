using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenu;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
 [Route("api/menu")]
 public class MenuController : ControllerBase
 {
 private readonly IMenuService _menuServices;
 public MenuController(IMenuService menuService)
 {
 _menuServices = menuService;
 }
 [HttpGet]
 [Route("{id}")]
 public IActionResult Get([FromRoute] int id)
 {
 var menu = _menuServices.GetById(id);
 if (menu == null)
 return NotFound();
 return Ok(menu);
 }
 [HttpGet]
 [Route("")]
 public IActionResult GetAll()
 {
 var menus = _menuServices.GetAll();
 return Ok(menus);
 }
 [HttpPost]
 [Route("")]
 public IActionResult Post([FromBody] Menu model)
 {
 _menuServices.Insert(model);
return Ok();
 }
 [HttpPut]
 [Route("")]
 public IActionResult Put([FromBody] Menu model)
 {
 _menuServices.Update(model);
 return Ok();
 }
 [HttpDelete]
 [Route("")]
 public IActionResult Delete([FromBody] Menu model)
 {
 _menuServices.Delete(model);
 return Ok();
 }
 }
}