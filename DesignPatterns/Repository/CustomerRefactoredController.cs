using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class CustomerRefactoredController : Controller {

  ICustomerRepository _repository;

  public CustomerRefactoredController() {
    _repository = new CustomerSqlRepository();
  }

  //GET api/customerrefactored
  [HttpGet]
  public IActionResult Get() {
    var customers = _repository.GetCustomers();
    return Ok(customers);
  }

  // PUT api/customerrefactored/name
  [HttpPut("{name}")]
  public IActionResult Put(string name, [FromBody] Customer model) {
    // validation code ommitted for brevity
    _repository.UpdateCustomer(model);
    return Ok(model);
  }

}

