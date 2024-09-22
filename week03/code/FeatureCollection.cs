public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    public Feature[] Features { get; set; }
}

public class Feature
{
    public Properties Properties { get; set; }
}

// Properties.cs
public class Properties
{
    public string Place { get; set; }
    public double Mag { get; set; } // Renamed from Magnitude to match the JSON structure
}
