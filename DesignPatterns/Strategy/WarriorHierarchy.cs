using System;

public interface IWarrior {
  void Attack();
}

public class KungFuMaster : IWarrior {
  public void Attack () {
    Console.WriteLine("Dragon kick to the chest");
  }
}

public class Bowman : IWarrior {
  public void Attack () {
    Console.WriteLine("Bullseye from 50 meters away");
  }
}

public class LonesomeCowboy : IWarrior {
  public void Attack () {
    Console.WriteLine("Fire gun faster than own shadow");
  }
}