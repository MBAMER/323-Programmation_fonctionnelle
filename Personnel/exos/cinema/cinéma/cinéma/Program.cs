using cinéma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



List<Movie> frenchMovies = new List<Movie>() {
new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }
};

// 1
Console.WriteLine("\nExercice 1\n");
List<Movie> listWithFilter = frenchMovies
    .Where(o => o.Genre != "Comédie" && o.Genre != "Drame")
    .ToList();

listWithFilter.ForEach(o => Console.WriteLine(o.Title));


Console.WriteLine("\nExercice 2\n");
// 2
List<Movie> rating7 = frenchMovies
    .Where(o => o.Rating <= 7)
    .ToList();
rating7.ForEach(o => Console.WriteLine(o.Title));



Console.WriteLine("\nExercice 3\n");
// 3
List<Movie> yearCreate = frenchMovies
    .Where(o => o.Year <= 2000)
    .ToList();


yearCreate.ForEach(o => Console.WriteLine(o.Title));


Console.WriteLine("^\nExercice 4 \n");
// 4
List<Movie> doublageFrench = frenchMovies
    .Where(o => o.LanguageOptions.Contains("Français"))
    .ToList();


doublageFrench.ForEach(o => Console.WriteLine(o.Title));

Console.WriteLine("\nExercice 5\n");
// 5
List<Movie> pltaformNetflix = frenchMovies
    .Where(o => o.StreamingPlatforms.Contains("Netflix"))
    .ToList();


pltaformNetflix.ForEach(o => Console.WriteLine(o.Title));


Console.WriteLine("\nV2\n");
// 4
List<Movie> Version2 = frenchMovies
  .Where(o => o.LanguageOptions.Contains("Français"))
  .Where(o => o.StreamingPlatforms.Contains("Netflix"))
  .Where(o => o.Year <= 2000)
  .Where(o => o.Genre != "Comédie" && o.Genre != "Drame")
  .Where(o => o.Rating <= 7)
  .ToList();


Version2.ForEach(o => Console.WriteLine(o.Title));
