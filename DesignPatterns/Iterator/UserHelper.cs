using System.Collections.Generic;

public class UserHelper
{

  private List<User> _users;

  // we are exposing implementation details. bad.
  public List<User> GetAllUsers()
  {
    return _users;
  }
}

public class User
{
  public string Name { get; set; }
}