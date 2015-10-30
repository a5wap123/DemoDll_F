using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim.Models
{
    public class ListTopNew
    {
        public ListTopNew()
        {
            listTopNew = new List<TopNew>();
        }
        public string Title { get; set; }
        public List<TopNew> listTopNew { get; set; }
    }
    public class TopNew
    {
        public TopNew() { }
        public string UrlFilm { get; set; }
        public string Thumb { get; set; }
        public string NameFilm_1 { get; set; }
        public string NameFilm_2 { get; set; }
        public string Status { get; set; }

    }
}
