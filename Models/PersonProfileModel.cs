using System.Text.Json.Serialization;

namespace Blazorwind.Models;

public class PersonProfileModel
{
    [JsonPropertyName("name")]
    public NameModel Name { get; set; }

    [JsonPropertyName("location")]
    public LocationModel Location { get; set; }

    [JsonPropertyName("picture")]
    public PictureModel Picture { get; set; }

    public string FirstName => Name?.First;
    public string LastName => Name?.Last;
    public string ImageUrl => Picture?.Large;
    public string City => Location?.City;
    public string Country => Location?.Country;
}

public class NameModel
{
    [JsonPropertyName("first")]
    public string First { get; set; }

    [JsonPropertyName("last")]
    public string Last { get; set; }
}

public class PictureModel
{
    [JsonPropertyName("large")]
    public string Large { get; set; }
}

public class LocationModel
{
    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }
}

public class ApiResponse
{
    [JsonPropertyName("results")]
    public List<PersonProfileModel> Results { get; set; }
}