using GetNodeValue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DataFilm_HDPHim
{
    public class GetData_HDPhim
    {
        static Models.BaseJson.JsonFilm_DeCu json_FilmDeCu = new Models.BaseJson.JsonFilm_DeCu();
        static List<Models.Film_DeCu> listDeCu;
        static Models.BaseJson.JsonFilm_TopNew json_TopNew = new Models.BaseJson.JsonFilm_TopNew();
        static List<Models.ListTopNew> listTopNew;
        static Models.BaseJson.Json_ListFilmToPage json_ListFilmToPage = new Models.BaseJson.Json_ListFilmToPage();
        static List<Models.FilmItem> listFilmToPage;
        static Models.BaseJson.Json_ListFilmHome json_FilmHome = new Models.BaseJson.Json_ListFilmHome();
        static List<Models.ListFilmHome> listFilmHome;

        static Models.BaseJson.Json_Detail json_DetailFilm = new Models.BaseJson.Json_Detail();
        static Models.DetailFilm detailFilm;

        static Models.BaseJson.Json_Profile json_Profile = new Models.BaseJson.Json_Profile();
        static Models.Profile profile;

        static Models.BaseJson.Server json_Server = new Models.BaseJson.Server();
        static Models.Server server;
        #region BaseJson
        private static string BaseJsonDeCu()
        {
            if (json_FilmDeCu.status)
            {
                json_FilmDeCu.msg = "Thành công.";
                json_FilmDeCu.error_code = 0;
                json_FilmDeCu.data = listDeCu;
            }
            else
            {
                json_FilmDeCu.msg = "Lỗi";
                json_FilmDeCu.error_code = 1;
                json_FilmDeCu.data = listDeCu;
            }
            return JsonConvert.SerializeObject(json_FilmDeCu);
        }
        private static string BaseJsonTopNew()
        {
            if (json_TopNew.status)
            {
                json_TopNew.msg = "Thành công.";
                json_TopNew.error_code = 0;
                json_TopNew.data = listTopNew;
            }
            else
            {
                json_TopNew.msg = "Lỗi";
                json_TopNew.error_code = 1;
                json_TopNew.data = listTopNew;
            }
            return JsonConvert.SerializeObject(json_TopNew);
        }
        private static string BaseJsonListFilmToPage()
        {
            if (json_ListFilmToPage.status)
            {
                json_ListFilmToPage.msg = "Thành công.";
                json_ListFilmToPage.error_code = 0;
                json_ListFilmToPage.data = listFilmToPage;
            }
            else
            {
                json_ListFilmToPage.msg = "Lỗi";
                json_ListFilmToPage.error_code = 1;
                json_ListFilmToPage.data = listFilmToPage;
            }
            return JsonConvert.SerializeObject(json_ListFilmToPage);
        }
        private static string BaseJsonFilmHome()
        {
            if (json_FilmHome.status)
            {
                json_FilmHome.msg = "Thành công.";
                json_FilmHome.error_code = 0;
                json_FilmHome.data = listFilmHome;
            }
            else
            {
                json_FilmHome.msg = "Lỗi";
                json_FilmHome.error_code = 1;
                json_FilmHome.data = listFilmHome;
            }
            return JsonConvert.SerializeObject(json_FilmHome);
        }
        private static string BaseJsonDetail()
        {
            if (json_DetailFilm.status)
            {
                json_DetailFilm.msg = "Thành công.";
                json_DetailFilm.error_code = 0;
                json_DetailFilm.data = detailFilm;
            }
            else
            {
                json_DetailFilm.msg = "Lỗi";
                json_DetailFilm.error_code = 1;
                json_DetailFilm.data = detailFilm;
            }
            return JsonConvert.SerializeObject(json_DetailFilm);
        }
        private static string BaseJsonProFile()
        {
            if (json_Profile.status)
            {
                json_Profile.msg = "Thành công.";
                json_Profile.error_code = 0;
                json_Profile.data = profile;
            }
            else
            {
                json_Profile.msg = "Lỗi";
                json_Profile.error_code = 1;
                json_Profile.data = profile;
            }
            return JsonConvert.SerializeObject(json_Profile);
        }
        private static string BaseServer()
        {
            if (json_Server.status)
            {
                json_Server.msg = "Thành công.";
                json_Server.error_code = 0;
                json_Server.data = server;
            }
            else
            {
                json_Server.msg = "Lỗi";
                json_Server.error_code = 1;
                json_Server.data = server;
            }
            return JsonConvert.SerializeObject(json_Server);
        }

        #endregion
        #region Phim De Cu
        internal static string Get_DeCu(string html)
        {
            try
            {
                listDeCu = new List<Models.Film_DeCu>();
                var node = Getnode.GetOneTag(html, "ul", "id", "movie-carousel-top");
                foreach (var item in node.ChildNodes)
                {
                    Models.Film_DeCu itemDeCu = new Models.Film_DeCu();
                    itemDeCu.UrlFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0 }, "href");
                    itemDeCu.Thumb = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 0 }, "src");
                    itemDeCu.NameFilm_1 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, 0 }, "");
                    itemDeCu.NameFilm_2 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, 1 }, "");
                    itemDeCu.StatusFilm_1 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, 2 }, "");
                    var nodeItem = Getnode.GetOneTag(item.OuterHtml, "div", "class", "movie-carousel-top-item-meta");
                    itemDeCu.Status_2 = nodeItem.ChildNodes.Count == 4 ? Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, 3 }, "") : "";
                    itemDeCu.DescriptionFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, nodeItem.ChildNodes.Count - 1 }, "");
                    listDeCu.Add(itemDeCu);
                }

                if (listDeCu.Count == 0)
                {
                    json_FilmDeCu.status = false;
                }
                else
                {
                    json_FilmDeCu.status = true;
                }
            }
            catch
            {
                json_FilmDeCu.status = false;
            }

            return BaseJsonDeCu();
        }
        #endregion
        #region Phim Top New
        internal static string Get_TopNew(string html)
        {
            try
            {
                listTopNew = new List<Models.ListTopNew>();
                for (int i = 1; i <= 3; i++)
                {

                    List<Models.TopNew> topNew = new List<Models.TopNew>();
                    var node = Getnode.GetOneTag(html, "ul", "id", "tabs-" + i);
                    foreach (var item in node.ChildNodes)
                    {
                        Models.TopNew itemTopNew = new Models.TopNew();
                        itemTopNew.UrlFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0 }, "href");
                        var thumb = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0 }, "style");
                        thumb = thumb.Replace("background-image: url('", "");
                        thumb = thumb.Remove(thumb.IndexOf("');"));
                        itemTopNew.Thumb = thumb;
                        itemTopNew.NameFilm_2 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 1 }, "");
                        itemTopNew.NameFilm_1 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 0 }, "");
                        itemTopNew.Status = Getnode.GetValueHtmlToChird(item, new int[] { 1, 0 }, "");
                        topNew.Add(itemTopNew);
                    }
                    Models.ListTopNew item_listTopNew = new Models.ListTopNew();
                    switch (i)
                    {
                        case 1:
                            item_listTopNew.Title = "Phim lẻ mới";
                            break;
                        case 2:
                            item_listTopNew.Title = "Phim bộ mới";
                            break;
                        case 3:
                            item_listTopNew.Title = "Phim bộ full";
                            break;
                        default:
                            break;
                    }
                    item_listTopNew.listTopNew = topNew;
                    listTopNew.Add(item_listTopNew);
                }
                if (listTopNew.Count == 0)
                {
                    json_TopNew.status = false;
                }
                else
                {
                    json_TopNew.status = true;
                }

            }
            catch
            {
                json_FilmDeCu.status = false;
            }

            return BaseJsonTopNew();
        }


        #endregion
        #region Phim DataFilm
        internal static string Get_ListFilmToPage(string html)
        {
            listFilmToPage = new List<Models.FilmItem>();
            try
            {
                var node = Getnode.GetOneTag(html, "ul", "class", "list-movie");
                foreach (var item in node.ChildNodes)
                {
                    if (item.Name == "#text") continue;
                    Models.FilmItem filmItem = new Models.FilmItem();
                    filmItem.UrlFilm = Getnode.GetValueHtmlToChird(item, new int[] { 1 }, "href");
                    var thumb = Getnode.GetValueHtmlToChird(item, new int[] { 1, 1 }, "style");
                    thumb = thumb.Replace("background:url(", "");
                    thumb = thumb.Remove(thumb.IndexOf(");"));
                    filmItem.Thumb = thumb;
                    filmItem.NameFilm_1 = Getnode.GetValueHtmlToChird(item, new int[] { 1, 3, 1 }, "");
                    filmItem.NameFilm_2 = Getnode.GetValueHtmlToChird(item, new int[] { 1, 3, 3 }, "");
                    filmItem.StatusFilm = Getnode.GetValueHtmlToChird(item, new int[] { 1, 3, 5 }, "");
                    filmItem.Ribbon = Getnode.GetValueHtmlToChird(item, new int[] { 1, 3, 7 }, "");
                    listFilmToPage.Add(filmItem);
                }

                if (listFilmToPage.Count == 0)
                {
                    json_ListFilmToPage.status = false;
                }
                else
                {
                    json_ListFilmToPage.status = true;
                }

            }
            catch
            {
                json_ListFilmToPage.status = false;
            }

            return BaseJsonListFilmToPage();
        }


        #endregion
        #region Get Film Home
        internal static string Get_FilmHome(string html)
        {
            listFilmHome = new List<Models.ListFilmHome>();
            try
            {
                var node = Getnode.GetListTag(html, "div", "class", "movie-list-index home-v2");
                foreach (var itemNode in node)
                {
                    Models.ListFilmHome i = new Models.ListFilmHome();

                    i.Title = Getnode.GetValueHtmlToChird(itemNode, new int[] { 0, 0, 0 }, "");
                    var nodeToItemNode = Getnode.GetListNodeToNode(itemNode, new int[] { 1, 0 });
                    foreach (var item in nodeToItemNode[0].ChildNodes)
                    {
                        Models.FilmItem t = new Models.FilmItem();
                        t.UrlFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0 }, "href");
                        var thumb = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 0, 0 }, "style");
                        thumb = thumb.Replace("background-image:url('", "");
                        thumb = thumb.Remove(thumb.IndexOf("')"));
                        t.Thumb = thumb;
                        t.NameFilm_1 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, 0 }, "");
                        t.NameFilm_2 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, 1 }, "");
                        t.StatusFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, 2 }, "");
                        t.Ribbon = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0, 1, 3 }, "");
                        i.listFilmItem.Add(t);
                    }
                    listFilmHome.Add(i);
                }
                if (listFilmHome.Count == 0)
                {
                    json_FilmHome.status = false;
                }
                else
                {
                    json_FilmHome.status = true;
                }

            }
            catch
            {
                var t = listFilmHome;
                json_FilmHome.status = false;
            }
            return BaseJsonFilmHome();
        }
        #endregion
        #region Get Detail
        internal static string Get_FullDetailFilm(string html)
        {

            List<Models.Actor> listActor = Get_ActorFilm(html);
            List<Models.FilmItem> listRelaFilm = Get_RelaFilm(html);
            detailFilm = new Models.DetailFilm();
            try
            {

                var node = Getnode.GetOneTag(html, "div", "class", "movie-info");
                var nodeInfo = Getnode.GetListNodeToNode(node, new int[] { 0, 0, 0, 1, 0 })[0];

                int limit = node.ChildNodes.Count < 42 ? 42 - nodeInfo.ChildNodes.Count + 1 : 0;
                int l = 5;

                detailFilm.Thumb = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 1, 0, 0 }, "src");
                detailFilm.UrlFilm = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 1, 0, 2, 2, 0 }, "href");
                detailFilm.Description = Getnode.GetValueHtmlToChird(node, new int[] { 3, 2 }, "");
                detailFilm.NameFilm1 = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 0, 0 }, "");
                detailFilm.NameFilm2 = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 0, 1 }, "");
                detailFilm.Status = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 1 }, "");
                detailFilm.ImDB = Getnode.GetValueHtmlToTag(nodeInfo, "class", "movie-dd imdb");
                if (!string.IsNullOrEmpty(detailFilm.ImDB))
                {
                    detailFilm.Votes = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 6 }, "");
                    l = 0;
                }


                detailFilm.Year = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 15 - l }, "");
                detailFilm.OpenDate = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 18 - l }, "");
                detailFilm.Time = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 21 - l }, "");
                detailFilm.TotalEpisode = limit == 0 ? Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 24 - l }, "") : "";
                detailFilm.Quality = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 30 - limit }, "");
                detailFilm.Language = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 33 - limit }, "");
                detailFilm.Company = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 39 - limit }, "");
                detailFilm.View = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 1, 0, 42 - limit }, "");
                detailFilm.Actor = listActor;
                detailFilm.RelaFilm = listRelaFilm;

                var nodeDirector = Getnode.GetListNodeToTag(nodeInfo, "class", "movie-dd dd-director");
                foreach (var item in nodeDirector[0].ChildNodes)
                {
                    Models.Director i = new Models.Director();
                    if (item.Name == "#text") continue;
                    var value = Getnode.GetValueHtmlToChird(item, new int[] { }, "href");
                    i.UrlDirector = value;
                    i.DirectorName = Getnode.GetValueHtmlToChird(item, new int[] { }, "");
                    detailFilm.ArrDirector.Add(i);
                }


                var nodeCountry = Getnode.GetListNodeToTag(nodeInfo, "class", "movie-dd dd-country");
                var dCountry = Common.AddDicCountry();
                foreach (var item in nodeCountry[0].ChildNodes)
                {
                    Models.Country iCountry = new Models.Country();
                    if (item.Name == "#text") continue;
                    var value = Getnode.GetValueHtmlToChird(item, new int[] { }, "href");
                    iCountry.NameCountry = Getnode.GetValueHtmlToChird(item, new int[] { }, "");
                    iCountry.EnumCountry = dCountry.FirstOrDefault(t => t.Value == value).Key;
                    detailFilm.ArrCountry.Add(iCountry);
                }


                var nodeGenre = Getnode.GetListNodeToTag(nodeInfo, "class", "movie-dd dd-cat");
                var dGenre = Common.AddDicGenre();
                foreach (var item in nodeGenre[0].ChildNodes)
                {
                    Models.Genre i = new Models.Genre();
                    if (item.Name == "#text") continue;
                    var value = Getnode.GetValueHtmlToChird(item, new int[] { }, "href");
                    i.NameGenre = Getnode.GetValueHtmlToChird(item, new int[] { }, "");
                    i.EnumGenre = dGenre.FirstOrDefault(t => t.Value == value).Key;
                    detailFilm.ArrGenre.Add(i);
                }
                json_DetailFilm.status = true;
            }

            catch
            {
                json_DetailFilm.status = false;
            }
            return BaseJsonDetail();
        }




        private static List<Models.FilmItem> Get_RelaFilm(string html)
        {
            List<Models.FilmItem> listRelaFilm = new List<Models.FilmItem>();
            try
            {
                var node = Getnode.GetOneTag(html, "ul", "class", "list-movie");
                foreach (var item in node.ChildNodes)
                {
                    Models.FilmItem filmItem = new Models.FilmItem();
                    filmItem.UrlFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0 }, "href");
                    var thumb = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0 }, "style");
                    thumb = thumb.Replace("background:url(", "");
                    thumb = thumb.Remove(thumb.IndexOf(");"));
                    filmItem.Thumb = thumb;
                    filmItem.NameFilm_1 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 0 }, "");
                    filmItem.NameFilm_2 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 1 }, "");
                    filmItem.StatusFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 2 }, "");
                    listRelaFilm.Add(filmItem);
                }
            }
            catch
            { }
            return listRelaFilm;
        }

        private static List<Models.Actor> Get_ActorFilm(string html)
        {
            List<Models.Actor> listActor = new List<Models.Actor>();
            try
            {
                var node = Getnode.GetOneTag(html, "ul", "id", "list_actor_carousel");
                foreach (var item in node.ChildNodes)
                {
                    Models.Actor actor = new Models.Actor();
                    var thumb = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0 }, "style");
                    thumb = thumb.Replace("background-image:url('", "");
                    thumb = thumb.Remove(thumb.IndexOf("')"));
                    actor.Thumb = thumb;
                    actor.UrlActor = Getnode.GetValueHtmlToChird(item, new int[] { 0 }, "href");
                    actor.Name = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 0 }, "");
                    actor.As = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 1 }, "");
                    listActor.Add(actor);
                }
            }
            catch
            {

            }
            return listActor;

        }
        #endregion
        #region Get hồ sơ
        internal static string Get_Profile(string html)
        {
            profile = new Models.Profile();
            try
            {
                var node = Getnode.GetOneTag(html, "div", "class", "movie-info");
                profile.Name = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 0, 0 }, "");
                profile.Thumb = Getnode.GetValueHtmlToChird(node, new int[] { 0, 0, 1, 0, 0 }, "src");
                var nodeInfo = Getnode.GetListNodeToNode(node, new int[] { 0, 0, 0, 1, 0 })[0];
                profile.Birthday = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 1 }, "");
                profile.Job = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 4 }, "");
                profile.Country = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 7 }, "");
                profile.Height = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 10 }, "");
                profile.Weight = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 13 }, "");
                profile.BoolTyle = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 16 }, "");
                profile.Language = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 19 }, "");
                profile.Forte = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 22 }, "");
                profile.Like = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 25 }, "");
                profile.Views = Getnode.GetValueHtmlToChird(nodeInfo, new int[] { 28 }, "");
                profile.List_Profile_FilmRela = Get_Profile_FilmRela(html);
                json_Profile.status = true;
            }
            catch
            {
                json_Profile.status = false;
            }
            return BaseJsonProFile();
        }


        private static DataFilm_HDPHim.Models.Profile_FilmRela Get_Profile_FilmRela(string html)
        {
            DataFilm_HDPHim.Models.Profile_FilmRela i = new Models.Profile_FilmRela();
            i.Title = "Một số phim đã tham gia";
            var node = Getnode.GetOneTag(html, "ul", "class", "list-movie");
            foreach (var item in node.ChildNodes)
            {
                Models.FilmItem filmItem = new Models.FilmItem();
                var thumb = Getnode.GetValueHtmlToChird(item, new int[] { 0, 0 }, "style");
                thumb = thumb.Replace("background:url(", "");
                thumb = thumb.Remove(thumb.IndexOf(");"));
                filmItem.Thumb = thumb;
                filmItem.UrlFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0 }, "href");
                filmItem.NameFilm_1 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 0 }, "");
                filmItem.NameFilm_2 = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 1 }, "");
                filmItem.StatusFilm = Getnode.GetValueHtmlToChird(item, new int[] { 0, 1, 2 }, "");
                i.ListFilmItem.Add(filmItem);
            }
            return i;
        }
        #endregion
        #region Get ListEpisode
        internal static string Get_Server(string html)
        {
            server = new Models.Server();
            try
            {
                var node = Getnode.GetOneTag(html, "div", "class", "list-server");
                var nodeDescription = Getnode.GetOneTag(html, "div", "class", "block-wrapper page-single block-note");
                foreach (var item in nodeDescription.ChildNodes)
                {
                    if (item.Name != "#text") continue;
                    server.Descripton +=Getnode.GetValueHtmlToChird(item, new int[] { }, "") + "\n";
                }
                foreach (var item in node.ChildNodes)
                {
                     Models.ListEpiside listEpisode = new Models.ListEpiside();
                    listEpisode.Title = Getnode.GetValueHtmlToChird(item, new int[] { 0 }, "");
                    var nodeEpisode = Getnode.GetListNodeToNode(item, new int[] { 1 })[0];
                    foreach (var itemNode in nodeEpisode.ChildNodes)
                    {
                        Models.Episode ep = new Models.Episode();
                        ep.ID = Getnode.GetValueHtmlToChird(itemNode, new int[] { 0 }, "data-episodeid");
                        ep.Name = Getnode.GetValueHtmlToChird(itemNode, new int[] {  }, "");
                        ep.Title = Getnode.GetValueHtmlToChird(itemNode, new int[] { 0 }, "title");
                        ep.Url = Getnode.GetValueHtmlToChird(itemNode, new int[] { 0 }, "href");
                        listEpisode.Episode.Add(ep);
                    }
                    server.ListEpiside.Add(listEpisode);
                }
                json_Server.status = true;
            }
            catch
            {
                json_Server.status = false;
            }
            return BaseServer();

        }
        #endregion
        #region Get quality
        internal  async static System.Threading.Tasks.Task<string> Get_Quaylity(string html)
        {
            string json = "";
            Regex reg = new Regex(@"currentEpisode.url='(?<link>[^""]+)';");
            var math = reg.Match(html);
            if (math.Success)
            {
                var link = math.Groups["link"].ToString();
                link = link.Remove(link.IndexOf("';"));
                if (!string.IsNullOrEmpty(link))
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add("X-Cache-Author ", "Vu Thanh Lai");
                    json = await Utils.HttpClientRequert(Common.UrlPostQuaylity, dic, "post",new Dictionary<string,string>
                        ()
                        {
                            {"url",link}
                        }
                        );
                }
            }
            return json;
        }
        #endregion
    }
}
