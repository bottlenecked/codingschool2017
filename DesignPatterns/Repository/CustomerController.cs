using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CustomerController : Controller {

  //GET api/customer
  [HttpGet]
  public IActionResult Get() {
    var customers = CustomerHelper.GetCustomers();
    return Ok(customers);
  }

  // PUT api/customer/name
  [HttpPut("{name}")]
  public IActionResult Put(string name, [FromBody] Customer model) {
    if (model == null || string.IsNullOrEmpty(model.Name)) {
      return BadRequest();
    }

    CustomerHelper.UpdateCustomer(model);

    return Ok(model);
  }

}