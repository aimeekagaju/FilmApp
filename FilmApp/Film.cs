using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmApp
{
    public class Film
    {
        [Required]
        public int FilmId { get; set; }
        [MaxLength(100)]
        public string Titre { get; set; } = null!;
        [Required]
        public int Annee { get; set; }
        [MaxLength(100)]
        public string ActeurPrincipal { get; set; } = null!;
        [MaxLength(100)] 
        public string Genre { get; set; } = null!;
        [MaxLength(100)] 
        public string Realisateur { get; set; } = null!;

        public List<Personne> Personnes { get; set; } = null!;
    }

}
