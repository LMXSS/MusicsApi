using MusicsApi.Models;
using MusicsApi.Filters;
using System.Text.Json;


using (HttpClient client = new HttpClient())
{
    try
    {
        string songApi = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(songApi);

        var musics = JsonSerializer.Deserialize<List<Musics>>(songApi)!;

        GenderFilter.AllGenderFilter(musics);

        //Console.WriteLine(musics.Count);
    }
    catch(Exception ex)
    {
        throw new Exception("Por favor Verifique a conexão com a API [songApi]");
    }

}
