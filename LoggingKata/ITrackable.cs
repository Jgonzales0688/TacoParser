namespace LoggingKata
{// TODO: Create two `ITrackable` variables with initial values of `null`. These will be used to store your two taco bells that are the farthest from each other.
 // Create a `double` variable to store the distance
    public interface ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }
    }
}