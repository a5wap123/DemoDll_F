using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFilm_HDPHim
{
    public class Config
    {
        public async static Task<string> Film_Decu()
        {
            var html = await Utils.HttpClientRequert(Common.UriHome);
            return GetData_HDPhim.Get_DeCu(html);
        }
        public async static Task<string> Film_TopNew()
        {
            var html = await Utils.HttpClientRequert(Common.UriHome);
            return GetData_HDPhim.Get_TopNew(html);
        }

        public async static Task<string> Film_Home()
        {
            var html = await Utils.HttpClientRequert(Common.UriHome);
            return GetData_HDPhim.Get_FilmHome(html);
        }
        public async static Task<string> FilmToPageChieuRap(string idPage)
        {
            var html = await (Utils.HttpClientRequert(Common.UriFilmChieuRap(idPage)));
            return GetData_HDPhim.Get_ListFilmToPage(html);
        }
        public async static Task<string> FilmKinhDien(string idPage)
        {
            var html = await (Utils.HttpClientRequert(Common.UrlFilmKinhDien(idPage)));
            return GetData_HDPhim.Get_ListFilmToPage(html);
        }
        public async static Task<string> FilmLe(string idPage, DataFilm_HDPHim.Enum.Year year = Enum.Year.none)
        {
            var html = await (Utils.HttpClientRequert(Common.UrlFilmLe(idPage, year)));
            return GetData_HDPhim.Get_ListFilmToPage(html);
        }
        public async static Task<string> FilmBo(string idPage, DataFilm_HDPHim.Enum.Catolog catolog = Enum.Catolog.none)
        {
            var html = await (Utils.HttpClientRequert(Common.UrlFilmBo(idPage, catolog)));
            return GetData_HDPhim.Get_ListFilmToPage(html);
        }
        public async static Task<string> FilmToTheLoai(string idPage, DataFilm_HDPHim.Enum.Genre genre)
        {
            var html = await (Utils.HttpClientRequert(Common.UriFilmToGenre(idPage, genre)));
            return GetData_HDPhim.Get_ListFilmToPage(html);
        }
        public async static Task<string> FilmToCountry(string idPage, DataFilm_HDPHim.Enum.Country country)
        {
            var html = await (Utils.HttpClientRequert(Common.UrlFilmQuocGia(idPage, country)));
            return GetData_HDPhim.Get_ListFilmToPage(html);
        }
        public async static Task<string> FilmTop10Imdb()
        {
            var html = await (Utils.HttpClientRequert(Common.Top10_Imdb));
            return GetData_HDPhim.Get_ListFilmToPage(html);
        }
        public async static Task<string> DetailFilm(string url)
        {
            var html = await (Utils.HttpClientRequert(Common.UriDetailFilm(url)));
            return GetData_HDPhim.Get_FullDetailFilm(html);
        }
        public async static Task<string> ProFile(string url)
        {
            var html = await (Utils.HttpClientRequert(Common.UriProfile(url)));
            return GetData_HDPhim.Get_Profile(html);
        }
        public async static Task<string> Episode(string url)
        {
            var html = await (Utils.HttpClientRequert(Common.UriServer(url)));
            return GetData_HDPhim.Get_Server(html);
        }
        public async static Task<string> Quality(string url)
        {
            var html = await (Utils.HttpClientRequert(Common.UriServer(url)));
            return await GetData_HDPhim.Get_Quaylity(html);
        }

    }
}
