using MusicsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicsApi.Filters;

internal class GenderFilter
{
    public static void AllGenderFilter(List<Musics> musics)
    {
        var allGenders = musics.Select(genders => genders.Genre).Distinct().ToList();

        foreach (var Genre in allGenders) 
        {
            Console.WriteLine($"- {Genre}");
        }
    }
}
