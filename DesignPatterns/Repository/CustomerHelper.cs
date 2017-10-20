using System.Collections.Generic;
using System.Data.SqlClient;

public class CustomerHelper {

  public static IEnumerable<Customer> GetCustomers(){
    using (var conn = new SqlConnection("some database")){
      conn.Open();
      using(var cmd = new SqlCommand("SELECT TOP * FROM CUSTOMERS")){
        using(var reader = cmd.ExecuteReader()){
          while(reader.Read()){
            yield return new Customer((string) reader["Name"]);
          }
        }
      }
    }    
  }

  public static void UpdateCustomer(Customer customer){
    using (var conn = new SqlConnection("some database")){
      conn.Open();
      using(var cmd = new SqlCommand("UPDATE CUSTOMERS SET AGE=@age WHERE NAME=@name")){
        cmd.Parameters.AddWithValue("@name", customer.Name);
        cmd.Parameters.AddWithValue("@age", customer.Age);
        cmd.ExecuteNonQuery();
      }
    }    
  }

}

public class Customer {
  public Customer(string name) => Name = name;

  public string Name { get; private set; }
  public int Age {get; set;}
}