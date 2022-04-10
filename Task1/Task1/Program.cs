using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Users\ricar\Documents\Visual C#\Task1\input.txt");
            string jsonString = r.ReadToEnd();
            List<MovieStar> movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(jsonString);
            foreach(MovieStar movieStar in movieStars)
            {
                Console.WriteLine(movieStar.Name + " " + movieStar.Surname);
                Console.WriteLine(movieStar.Sex);
                Console.WriteLine(movieStar.Nationality);
                Console.WriteLine(movieStar.Age() + "years old");
                Console.WriteLine();
            }
        }
    }
}
