using System;
using System.Collections.Generic;
using System.Linq;

namespace JukeBox
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Juke Box");

      var allSongs = new List<Song>() { new Song("Creed", "With Arms Wide Open"), new Song("Creed", "My Own Prison"), new Song("Creed", "One Last Breath"), new Song("Creed", "My Sacrifice"), new Song("Marshall Tucker Band", "Can't You See"), new Song("Fleetwood Mac", "Sara"), new Song("Led Zeppelin", "Starway to Heaven"), new Song("Tool", "Pneuma"), new Song("St. Paul and The Broken Bones", "Apollo"), new Song("Sturgill Simpson", "Hero"), new Song("Corey Taylor", "Snuff"), new Song("Eddie Money", "Shakin") };
      var goodSongs = allSongs.Where(song => song.Artist != "Creed").ToList();

      foreach (var song in goodSongs)
      {
        Console.WriteLine($"{song.Artist} : {song.Name}");
      }
    }
  }
}
