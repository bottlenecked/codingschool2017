using System.Collections.Generic;
using System.Data.SqlClient;

public interface ICustomerRepository {
  
  IEnumerable<Customer> GetCustomers();

  void UpdateCustomer(Customer customer);

}

public class CustomerSqlRepository : ICustomerRepository {
  public IEnumerable<Customer> GetCustomers() {
    using (var conn = new SqlConnection("some database")) {
      conn.Open();
      using(var cmd = new SqlCommand("SELECT TOP * FROM CUSTOMERS")) {
        using(var reader = cmd.ExecuteReader()){
          while(reader.Read()){
            yield return new Customer((string) reader["Name"]);
          }
        }
      }
    }    
  }

  public void UpdateCustomer(Customer customer) {
    using (var conn = new SqlConnection("some database")) {
      conn.Open();
      using(var cmd = new SqlCommand("UPDATE CUSTOMERS SET AGE=@age WHERE NAME=@name")) {
        cmd.Parameters.AddWithValue("@name", customer.Name);
        cmd.Parameters.AddWithValue("@age", customer.Age);
        cmd.ExecuteNonQuery();
      }
    }    
  }
}