using Movie.라이브러리;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Movie_main movie = new Movie_main())
            {
                movie.Run();
            }
        }
    }
}
