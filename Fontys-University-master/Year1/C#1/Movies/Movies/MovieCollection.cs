using System.Collections;

namespace Movies
{
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    using System.Collections.Generic;

    public class MovieCollection
    {
        private const string FILENAME = "C:\\Users\\lenovo\\Desktop";


        private List<Movie> movieList = new List<Movie>();

        /// <summary>
        /// Adds a movie to the collection
        /// </summary>
        /// <param name="movie">The movie to add</param>
        public void Add(Movie movie)
        {
            movieList.Add(movie);
        }

        /// <summary>
        /// Returns all movies that match the search key. The search is applied to the title and director
        /// </summary>
        /// <param name="key">The text to search for</param>
        /// <returns>All movies that match the key</returns>
        public List<Movie> Search(string key)
        {
            List<Movie> searchResults = new List<Movie>();

            // find the movies
            foreach (Movie current in movieList)
            {
                // copy each match into the new list
                if (current.Title.Contains(key) ||
                    current.Director.Contains(key))
                {
                    searchResults.Add(current);
                }
            }

            // return the list
            return searchResults;
        }

        /// <summary>
        /// Returns all movies produced in a year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public List<Movie> Search(int year)
        {
            List<Movie> results = new List<Movie>();

            foreach (Movie current in movieList)
            {
                if (current.Year == year)
                    results.Add(current);
            }

            return results;
        }

        /// <summary>
        /// Returns all movies in the collection
        /// </summary>
        /// <returns>The movie list</returns>
        public List<Movie> GetAll()
        {
            return movieList;
        }

        ///   e movie database to disk
        /// </summa<summary>
        /// Savry>
        public void Save()
        {
            Stream stream = File.Open(FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, movieList);
            stream.Close();
        }

        /// <summary>
        /// Load movie database from disk
        /// </summary>
        public void Load()
        {
            if (File.Exists(FILENAME))
            {
                Stream stream = File.Open(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                movieList = (List<Movie>)formatter.Deserialize(stream);
                stream.Close();
            }
        }
    }
}
