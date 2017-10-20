using System.Collections.Generic;
using System.Linq;

public class UserHelperRefactored
{

  private List<User> _users;

  // you can just enumerate the returned collection.
  // nothing else can be assumed. good :)
  public IEnumerable<User> GetAllUsers()
  {
    return _users;
  }

}

public class UserHelperRefactored2
{

  // the backing store has changed...
  private Dictionary<string, User> _users;

  public IEnumerable<User> GetAllUsers()
  {

    // but our users don't have to change their code
    // just because we changed ours!
    return _users.Select(kvp => kvp.Value);
  }
}

