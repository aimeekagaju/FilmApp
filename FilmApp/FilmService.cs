using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp
{
    public class FilmService
    {
        private readonly AppDbContext _context;

        // Constructor
        public FilmService(AppDbContext context)
        {
            _context = context;
        }

        public void InsertFilms(List<Film> films)
        {
            
            _context.Films.AddRange(films);

            // sauver les changements
            _context.SaveChanges();
            Console.WriteLine("Films inserted successfully.");
        }
        public void InsertFilm(Film film)
        {

            _context.Films.Add(film);


            _context.SaveChanges(film);
            Console.WriteLine("Films inserted successfully.");
        }
    }
}
