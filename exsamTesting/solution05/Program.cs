using System;

namespace solution05
{
    class Program
    {
        static void Main(string[] args)
        {

            int numFilms = int.Parse(Console.ReadLine());
            string movieName = "";
            double rating = 0;
            double ratingMax = double.MinValue;
            double ratingMin = double.MaxValue;
            string movieMax = "";
            string movieMin = "";
            double allRating = 0;

            for (int i = 1; i <= numFilms; i++)
            {
                movieName = Console.ReadLine();
                rating = double.Parse(Console.ReadLine());

                if (ratingMax <= rating)
                {
                    ratingMax = rating;
                    movieMax = movieName;
                }
                else
                {
                    ratingMin = rating;
                    movieMin = movieName;
                }
                allRating += rating;
            }
            
            Console.WriteLine($"{movieMax} is with highest rating: {ratingMax}");
            Console.WriteLine($"{movieMin} is with lowest rating: {ratingMin}");
            Console.WriteLine($"Average rating: {(allRating / numFilms):f1}");
        }
    }
}
