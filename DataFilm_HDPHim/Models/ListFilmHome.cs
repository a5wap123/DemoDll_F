using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim.Models
{
    public class ListFilmHome
    {
        public ListFilmHome()
        {
            listFilmItem = new List<FilmItem>();
        }
        public string Title { get; set; }
        public List<FilmItem> listFilmItem { get; set; }
    }
}
