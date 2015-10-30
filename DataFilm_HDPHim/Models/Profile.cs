using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim.Models
{
    public class Profile
    {
        public Profile()
        {
            List_Profile_FilmRela = new Profile_FilmRela();
        }
        public string Thumb { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Job { get; set; }
        public string Country { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BoolTyle { get; set; }
        public string Language { get; set; }
        public string Forte { get; set; }
        public string Like { get; set; }
        public string Views { get; set; }
        public Profile_FilmRela List_Profile_FilmRela { get; set; }
    }
    public class Profile_FilmRela
    {
        public Profile_FilmRela()
        {
            ListFilmItem = new List<FilmItem>();
        }
        public string Title { get; set; }
        public List<FilmItem>  ListFilmItem { get; set; }
      
    }
}
