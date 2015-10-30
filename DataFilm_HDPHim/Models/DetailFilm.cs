using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim.Models
{
    public class DetailFilm
    {
        public DetailFilm()
        {
            Actor = new List<Actor>();
            RelaFilm = new List<FilmItem>();
            ArrCountry = new List<Country>();
            ArrGenre = new List<Genre>();
            ArrDirector = new List<Director>();
        }
        public string UrlFilm { get; set; }
        public string Thumb { get; set; }
        public string Description { get; set; }
        public string NameFilm1 { get; set; }
        public string NameFilm2 { get; set; }
        public string Status { get; set; }
        public string ImDB { get; set; }
        public string Votes { get; set; }
        public List<Director> ArrDirector { get; set; }
        public List<Country> ArrCountry { get; set; }
        public List<Genre> ArrGenre { get; set; }
        public string Year { get; set; }
        public string OpenDate { get; set; }
        public string TotalEpisode { get; set; }
        public string Time { get; set; }
        public string Quality { get; set; }
        public string Language { get; set; }
        
        public string Company { get; set; }
        public string View { get; set; }
        public List<Actor> Actor { get; set; }
        public List<FilmItem> RelaFilm { get; set; }
    }
    public class Director
    {
        public string DirectorName { get; set; }
        public string UrlDirector { get; set; }
    }
    public class Actor
    {
        public string Thumb { get; set; }
        public string UrlActor { get; set; }
        public string Name { get; set; }
        public string As { get; set; }
    }
    public class Genre
    {
        public string NameGenre { get; set; }
        public Enum.Genre EnumGenre { get; set; }
    }
    public class Country
    {
        public string NameCountry { get; set; }
        public DataFilm_HDPHim.Enum.Country EnumCountry { get; set; }
    }
}
