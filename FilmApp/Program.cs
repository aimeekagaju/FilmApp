
using FilmApp;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Utilisation;

const string connectionString = @"Data Source=E6K-VDI20512\TFTIC;Initial Catalog=Film;Integrated Security=True;Trust Server Certificate=True";

DbContextOptions options =
        new DbContextOptionsBuilder()
            .UseSqlServer(connectionString).Options;
using AppDbContext context = new AppDbContext(options);
// Creer un instance de la classe dataset
DataSet dataSet = new DataSet();

// Creer une instance de filmservice pour inserer les données
var filmService = new FilmService(context);
Film film = new Film();
film.Annee = 2000;
film.Genre = "Action";
film.Realisateur = "Charlie Hannum";
film.ActeurPrincipal = "Charlie Hannum";
film.FilmId = 9;
film.Titre = "Le roi soleil";
// Insert films from the DataSet into the database
filmService.InsertFilm(film);

foreach (Film f in context.Films.Where(x => x.Annee < 2001))
{
    Console.WriteLine(f.FilmId + " - " + f.Titre + " - " + f.Realisateur + " - " + f.Genre + " - " + f.Annee + " - " + f.ActeurPrincipal);
}