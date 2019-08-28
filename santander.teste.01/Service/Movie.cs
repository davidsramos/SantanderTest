using Newtonsoft.Json;
using santander.teste._01.Exception;
using santander.teste._01.Models;
using System;
using System.IO;
using System.Net;

namespace santander.teste._01.Service
{
    public class Movie : IMovie
    {
        private CollectionMovieModel requestMovies(string title)
        {
            string apiUrl = Properties.Resources.ResourceManager.GetString("ApiUrl");

            var url = apiUrl + title;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                CollectionMovieModel movies = JsonConvert.DeserializeObject<CollectionMovieModel>(streamReader.ReadToEnd());

                return movies;
            }
        }

        private void validateTitle(string title) 
        {
            int titleLength = title.Length;

            if (titleLength <= 0 || titleLength > 20)
            {
                throw new InvalidTitleException();
            }
        }

        public int getNumberOfMovies(string title)
        {
            CollectionMovieModel movies;

            try
            {
                validateTitle(title);
                movies = requestMovies(title);
            }
            catch (InvalidTitleException ex)
            {
                throw ex;
            }
            catch (System.Exception ex2)
            {
                throw ex2;
            }

            return movies.TotalResults;
        }
    }
}
