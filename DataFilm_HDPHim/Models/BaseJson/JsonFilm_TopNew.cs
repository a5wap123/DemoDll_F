using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim.Models.BaseJson
{
    public class JsonFilm_TopNew
    {
        public bool status;

        public int error_code;

        public string msg;
        public List<Models.ListTopNew> data;
    }
}
