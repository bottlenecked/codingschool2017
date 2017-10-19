public class SingletonEager
{
  // a bit eager, are we?
  private static readonly Car _instance = FetchMeACar();

  public Car Car => _instance;

  private static Car FetchMeACar()
  {
    // go through all steps for getting a new car
    // ... and finally ...
    return new Car();
  }
}

public class Car { }

