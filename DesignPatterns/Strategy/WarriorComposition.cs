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

  public void Attack() {
    _weapon.Use();
  }
}

public class UltraFlexibleWarrior : IWarrior {
  private IWeapon _weapon;

  public UltraFlexibleWarrior(IWeapon weapon) {
    _weapon = weapon;
  }

  public void Attack() {
    _weapon.Use();
  }

  public void ChangeWeapon(IWeapon weapon){
    _weapon = weapon;
  }

}

public class WarriorTest {
  public void Run () {

    var sword = new Sword();
    var warrior = new FlexibleWarrior(sword);
    warrior.Attack();

    var gun = new SixShooter();
    warrior = new FlexibleWarrior(gun);
    warrior.Attack();

  }
}

public class UltraWarriorTest {
  public void Run() {
    var sword = new Sword();
    var leonidas = new UltraFlexibleWarrior(sword);
    // the tank appears...
    var rocketLauncher = new RocketLauncher();
    leonidas.ChangeWeapon(rocketLauncher);
    leonidas.Attack(); // tank bye bye
  }
}

