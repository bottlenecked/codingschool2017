using System;

public class SingletonLazy {

  private static Lazy<Car> _lazyCar = new Lazy<Car>(FetchMeACar);

  // the car will be created only when we actually need it
  public Car Car => _lazyCar.Value;

  private static Car FetchMeACar () {
    return new Car();
  }

}

