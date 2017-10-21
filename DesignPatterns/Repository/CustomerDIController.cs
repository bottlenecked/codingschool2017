using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CustomerDIController : Controller {

  ICustomerRepository _repository;

  public CustomerDIController(ICustomerRepository repository) {
    _repository = repository;
  }

  //GET api/customerrefactored1
  [HttpGet]
  public IActionResult Get() {
    var customers = _repository.GetCustomers();
    return Ok(customers);
  }

  // PUT api/customerrefactored1/name
  [HttpPut("{name}")]
  public IActionResult Put(string name, [FromBody] Customer model) {
    // validation code ommitted for brevity
    _repository.UpdateCustomer(model);
    return Ok(model);
  }

}