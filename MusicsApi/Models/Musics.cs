using System.Text.Json.Serialization;

namespace MusicsApi.Models;

public class Musics
{
    [JsonPropertyName("song")]
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }


    public void ShowDetails()
    {   
       
                                
    }
}
