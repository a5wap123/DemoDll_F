using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim
{

    class Common
    {
        //quoc-gia/
        static Dictionary<DataFilm_HDPHim.Enum.Genre, string> dicGenre;
        static Dictionary<DataFilm_HDPHim.Enum.Country, string> dicCountry;
        static Dictionary<DataFilm_HDPHim.Enum.Catolog, string> dicCatolog;
        static Dictionary<DataFilm_HDPHim.Enum.Year, string> dicYear;
        public Common() { }
        public static Dictionary<DataFilm_HDPHim.Enum.Genre, string> AddDicGenre()
        {
            if (dicGenre != null) return dicGenre;
            else
            {
                var t = "the-loai/";
                Dictionary<Enum.Genre, string> dic = new Dictionary<Enum.Genre, string>();
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimhaihuoc, t + "phim-hai-huoc/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimhanhdong, t + "phim-hanh-dong/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimvientuong, t + "phim-vien-tuong/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimthanthoai, t + "phim-than-thoai/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimchientranh, t + "phim-chien-tranh/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimhinhsu, t + "phim-hinh-su/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phieuluu, t + "phieu-luu/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimvothuat, t + "phim-vo-thuat/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimhoathinh, t + "phim-hoat-hinh/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimkinhdi, t + "phim-kinh-di/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimcotrang, t + "phim-co-trang/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimtamly, t + "phim-tam-ly/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimtailieu, t + "phim-tai-lieu/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimthethaoamnhac, t + "phim-the-thao-am-nhac/");
                dic.Add(DataFilm_HDPHim.Enum.Genre.phimgiadinh, t + "phim-gia-dinh/");

                return dic;
            }
        }
        public static Dictionary<DataFilm_HDPHim.Enum.Country, string> AddDicCountry()
        {
            if (dicCountry != null) return dicCountry;
            else
            {
                var t = "quoc-gia/";
                Dictionary<Enum.Country, string> dic = new Dictionary<Enum.Country, string>();
                dic.Add(DataFilm_HDPHim.Enum.Country.VietNam, t + "vn/");
                dic.Add(DataFilm_HDPHim.Enum.Country.American, t + "us/");
                dic.Add(DataFilm_HDPHim.Enum.Country.Anh, t + "uk/");
                dic.Add(DataFilm_HDPHim.Enum.Country.DaiLoan, t + "tw/");
                dic.Add(DataFilm_HDPHim.Enum.Country.ThaiLand, t + "th/");
                dic.Add(DataFilm_HDPHim.Enum.Country.Korean, t + "kr/");
                dic.Add(DataFilm_HDPHim.Enum.Country.Japan, t + "jp/");
                dic.Add(DataFilm_HDPHim.Enum.Country.HongKong, t + "hk/");
                dic.Add(DataFilm_HDPHim.Enum.Country.France, t + "fr/");
                dic.Add(DataFilm_HDPHim.Enum.Country.China, t + "cn/");
                dic.Add(DataFilm_HDPHim.Enum.Country.Canada, t + "ca/");
                dic.Add(DataFilm_HDPHim.Enum.Country.Uc, t + "au/");

                return dic;
            }
        }
        public static Dictionary<DataFilm_HDPHim.Enum.Catolog, string> AddDicCatolog()
        {
            if (dicCatolog != null) return dicCatolog;
            else
            {
                var t = "phim-bo/";
                Dictionary<Enum.Catolog, string> dic = new Dictionary<Enum.Catolog, string>();
                dic.Add(DataFilm_HDPHim.Enum.Catolog.none, t);
                dic.Add(DataFilm_HDPHim.Enum.Catolog.VietNam, t + "vn/");
                dic.Add(DataFilm_HDPHim.Enum.Catolog.American, t + "us/");
                dic.Add(DataFilm_HDPHim.Enum.Catolog.DaiLoan, t + "tw/");
                dic.Add(DataFilm_HDPHim.Enum.Catolog.Korean, t + "kr/");
                dic.Add(DataFilm_HDPHim.Enum.Catolog.HongKong, t + "hk/");
                dic.Add(DataFilm_HDPHim.Enum.Catolog.China, t + "cn/");
                return dic;
            }
        }
        public static Dictionary<DataFilm_HDPHim.Enum.Year, string> AddDicYear()
        {
            if (dicYear != null) return dicYear;
            else
            {
                string t = "phim-le/";
                Dictionary<Enum.Year, string> dic = new Dictionary<Enum.Year, string>();
                dic.Add(DataFilm_HDPHim.Enum.Year.none, t);
                dic.Add(DataFilm_HDPHim.Enum.Year.L2015, t + "2015/");
                dic.Add(DataFilm_HDPHim.Enum.Year.L2014, t + "2014/");
                dic.Add(DataFilm_HDPHim.Enum.Year.L2013, t + "2013/");
                dic.Add(DataFilm_HDPHim.Enum.Year.L2012, t + "2012/");
                dic.Add(DataFilm_HDPHim.Enum.Year.L2011, t + "2011/");
                dic.Add(DataFilm_HDPHim.Enum.Year.L2010, t + "2010/");
                dic.Add(DataFilm_HDPHim.Enum.Year.L2009, t + "2009/");
                dic.Add(DataFilm_HDPHim.Enum.Year.L_Duoi_2009, t + "-2009/");

                return dic;
            }
        }

        public static string UriHome = "http://www.phimmoi.net/";
        public static string Top10_Imdb = "http://www.phimmoi.net/tags/top+10+imdb+2014/";
        public static string UrlPostQuaylity = "http://www.phimmoi.net/player/v1.46/plugins/gkplugins_picasa2gdocs/plugins/plugins_player.php";
        #region Chiếu rạp
        public static string UriFilmChieuRap(string id)
        {
            return string.Format("http://www.phimmoi.net/phim-chieu-rap/page-{0}.html", id);
        }
        #endregion
        #region Thể loại
        public static string UriFilmToGenre(string id, DataFilm_HDPHim.Enum.Genre genre)
        {
            dicGenre = AddDicGenre();
            return string.Format("http://www.phimmoi.net/{1}/page-{0}.html", id, dicGenre.FirstOrDefault(t => t.Key == genre).Value);
        }
        #endregion
        #region Phim bộ
        public static string UrlFilmBo(string id, DataFilm_HDPHim.Enum.Catolog catalog = DataFilm_HDPHim.Enum.Catolog.none)
        {
            dicCatolog = AddDicCatolog();
            return string.Format("http://www.phimmoi.net/{1}page-{0}.html", id, dicCatolog.FirstOrDefault(t => t.Key == catalog).Value);
        }
        #endregion
        #region Phim lẻ
        public static string UrlFilmLe(string id, DataFilm_HDPHim.Enum.Year year = DataFilm_HDPHim.Enum.Year.none)
        {
            dicYear = AddDicYear();
            return string.Format("http://www.phimmoi.net/{1}page-{0}.html", id, dicYear.FirstOrDefault(t=>t.Key == year).Value);
        }
        #endregion
        #region Phim Kinh điển
        public static string UrlFilmKinhDien(string id)
        {
            return string.Format("http://www.phimmoi.net/phim-kinh-dien/page-{0}.html", id);
        }
        #endregion
        #region Quốc gia
        public static string UrlFilmQuocGia(string id, DataFilm_HDPHim.Enum.Country country)
        {
            dicCountry = AddDicCountry();
            return string.Format("http://www.phimmoi.net/{1}page-{0}.html", id, dicCountry.FirstOrDefault(t => t.Key == country).Value);
        }
        #endregion
        #region Detail Film
        internal static string UriDetailFilm(string url)
        {
            return url.StartsWith("http") ? url : string.Format("http://www.phimmoi.net/{0}", url);
        }
        #endregion

        #region Hồ sơ
        internal static string UriProfile(string url)
        {
            return url.StartsWith("http") ? url : string.Format("http://www.phimmoi.net/{0}", url);
        }
        #region Episode
        internal static string UriServer(string url)
        {
            return url.StartsWith("http") ? url : string.Format("http://www.phimmoi.net/{0}", url);
        }
        #endregion
        #endregion
    }
}
