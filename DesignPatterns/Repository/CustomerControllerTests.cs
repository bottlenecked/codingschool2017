using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

public class CustomerControllerTests {

  [Fact]
  public void Get_ReturnsAllCustomers() {
    // Arrange
    var customerList = new [] {
      new Customer("John") {Age = 30},
      new Customer("Liz") {Age = 25}
    };

    var mockRepo = new Mock<ICustomerRepository>();
    mockRepo.Setup(repo => repo.GetCustomers())
      .Returns(customerList);
    var controller = new CustomerDIController(mockRepo.Object);

    // Act
    var result = controller.Get() as OkObjectResult;

    // Assert
    Assert.NotNull(result);
    Assert.Equal(200, result.StatusCode);
    Assert.Equal(customerList, result.Value as IEnumerable<Customer>);
  }

}

