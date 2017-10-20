using System;
using System.Collections.Generic;

public class RoadtripPolling {

  Kid littleGeorge = new Kid();

  public void OnTheRoad() {    
    
    // an hour passes
    while (true) {
      littleGeorge.AskQuestion("Are we there yet;");
    }

  }
}

public class Kid {
  public void AskQuestion(string question){
    Console.WriteLine(question);
  }

  public void Tell(string text) {
    // these kids just don't listen to anything you say
  }
}