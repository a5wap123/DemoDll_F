using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim.Models
{
    public class Server
    {
        public Server()
        {
            ListEpiside = new List<ListEpiside>();
        }
        public string Descripton { get; set; }
        public List<ListEpiside> ListEpiside { get; set; }
    }
    public class ListEpiside
    {
        public ListEpiside()
        {
            Episode = new List<Episode>();
        }
        public string Title { get; set; }
        public List<Episode> Episode { get; set; }
    }
    public class Episode
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string ID { get; set; }
        public string Url { get; set; }
    }

}
