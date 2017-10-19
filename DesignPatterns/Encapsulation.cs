public class NakedCounter {
    // public exposed field means clients have direct access to internal state. Bad.
    public int CurrentCount;
}

public class EncapsulatedCounter {

    private int _currentCount; // no one can access internal data

    public int CurrentCount {
        get {
            // I can add custom logic before returning the count
            Log("current count requested");
            return _currentCount;
        }
    }

    private void Log(string message) {
        //log message
    }
}