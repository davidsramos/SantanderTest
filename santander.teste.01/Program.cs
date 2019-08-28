using santander.teste._01.Exception;
using santander.teste._01.Service;
using SimpleInjector;
using System;

namespace santander.teste._01
{
    class Program
    {
        private static readonly Container container;

        static Program()
        {
            container = new Container();
            container.Register<IMovie, Movie>();
            container.Verify();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter movie title: ");
            string val = Console.ReadLine();
                       
            var MovieService = container.GetInstance<IMovie>();            
            int numMovies;

            try
            {
                numMovies = MovieService.getNumberOfMovies(val);
                Console.WriteLine("Total movies: " + numMovies.ToString());
            }
            catch (InvalidTitleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Communication Failed!");
            }

            Console.ReadKey();
        }
    }
}
