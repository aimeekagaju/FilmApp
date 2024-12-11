using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp
{
    public class Personne
    {
        [Key]
        public int Id { get; set; }
        public string Acteur { get; set; } = null!;
        public string Realisateur { get; set; } = null!;
        public List<Film> Films { get; set; } = null!;
    }
    
}
