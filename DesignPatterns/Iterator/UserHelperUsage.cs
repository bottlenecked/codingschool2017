using System.Collections.Generic;

public class UserHelperUsage
{

  public void DoWork()
  {

    var helper = new UserHelper();
    List<User> users = helper.GetAllUsers();

    // is this the intended usage?
    var newUser = new User { Name = "Joe" };
    users.Add(newUser);

  }
}