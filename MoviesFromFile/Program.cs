using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MoviesFromFile
{
    class Program
    {
        class Movie
        {
            string title;
            string rating;
            string year;
            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }


            public string Title
            {
                get { return title; }
            }

            public string Rating
            {
                get { return rating; }
            }

            public string Year
            {
                get { return year; }
            }
        }
        static void Main(string[] args)
        {
            List<string> movieListFromFile = getMoviesFromFile().ToList();
            List<Movie> listofMovies = new List<Movie>();

            foreach(string movieRecord in movieListFromFile)
            {
                string[] tempArray = movieRecord.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);

                listofMovies.Add(newMovie);
            }


            foreach (Movie movie in listofMovies)
            {
                Console.WriteLine($"Title: {movie.Title} - rating: {movie.Rating} - year: {movie.Year}");
            }
        }

        public static string[] getMoviesFromFile()
        {

            string filePath = @"C:\Users\opilane\Samples\Movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }

        public static void ShowDataFromArray(string[] someArray)
        {
            foreach(string line in someArray)
            {
                Console.WriteLine(line);
            }
        }

    }
}
