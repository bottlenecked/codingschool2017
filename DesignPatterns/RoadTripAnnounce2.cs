using System;
using System.Collections.Generic;
using System.Linq;

public class QuietRoadTrip {

  private List<KidThatListens> _kids;


  public event EventHandler<string> OnArrival;

  public QuietRoadTrip (){
    _kids = new List<KidThatListens> { new KidThatListens("George"), new KidThatListens("Annie")};
  }

  public void OnTheRoad (){

    var george = _kids.First(k => k.Name == "George");
    var annie = _kids.First(k => k.Name == "Annie");

    // at some point in the trip little George and little Annie
    // want to know when we'll arrive
    this.OnArrival += george.LetMeKnow;
    this.OnArrival += annie.LetMeKnow;

    // annie wants to sleep however at some point, and
    // doesn't care anymore when she gets there
    this.OnArrival -= annie.LetMeKnow;

    //after 8 hours of travelling we arrive at our destination
    this.OnArrival?.Invoke(this, "We're there!");

    // george whoops, but annie is still asleep

  }
}

public class KidThatListens {

  public KidThatListens(string name) => Name = name;

  public string Name { get; }

  public void LetMeKnow(object o, string information){
    // do something with newfound info
  }
}