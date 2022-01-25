using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SStaff;
using Microsoft.AspNetCore.Mvc;
namespace ApexRestaurant.Api.Controller
{
 [Route("api/staff")]
 public class StaffController : ControllerBase
 {
 private readonly IStaffService _staffServices;
 public StaffController(IStaffService staffService)
 {
 _staffServices = staffService;
 }
 [HttpGet]
 [Route("{id}")]
 public IActionResult Get([FromRoute] int id)
 {
 var staff = _staffServices.GetById(id);
 if (staff == null)
 return NotFound();
 return Ok(staff);
 }
 [HttpGet]
 [Route("")]
 public IActionResult GetAll()
 {
 var staffs = _staffServices.GetAll();
 return Ok(staffs);
 }
 [HttpPost]
 [Route("")]
 public IActionResult Post([FromBody] Staff model)
 {
 _staffServices.Insert(model);
return Ok();
 }
 [HttpPut]
 [Route("")]
 public IActionResult Put([FromBody] Staff model)
 {
 _staffServices.Update(model);
 return Ok();
 }
 [HttpDelete]
 [Route("")]
 public IActionResult Delete([FromBody] Staff model)
 {
 _staffServices.Delete(model);
 return Ok();
 }
 }
}