using System;

public interface IWeapon {
  void Use();
}

public class Sword : IWeapon {
  public void Use() => Console.WriteLine("Stab stab stab");
}

public class SixShooter : IWeapon {
  public void Use() => Console.WriteLine("Bang bang");
}

public class RocketLauncher : IWeapon {
  public void Use() => Console.WriteLine("KABOOM!");
}

public class FlexibleWarrior : IWarrior {
  private IWeapon _weapon;

  public FlexibleWarrior(IWeapon weapon) {
    _weapon = weapon;
  }

  public void Attack()
  {
    _weapon.Use();
  }
}