public class Dad {

  private System.Collections.Generic.List<Kid> _kids;

  public void AnnounceArrival() {
    foreach (var kid in _kids){
      kid.Tell("We're there!");
    }
  }
}