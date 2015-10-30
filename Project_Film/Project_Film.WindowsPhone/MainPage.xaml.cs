using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Project_Film
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.Film_Decu();
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonTopNew_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.Film_TopNew();
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonTheLoai_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmToTheLoai("1", DataFilm_HDPHim.Enum.Genre.phieuluu);
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonLe_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmLe("1");
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonBo_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmBo("1");
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonKinhDien_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmKinhDien("1");
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonRap_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmToPageChieuRap("1");
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonQuocGia_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmToCountry("1",DataFilm_HDPHim.Enum.Country.Korean);
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonTop10Imdb_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmTop10Imdb();
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.Film_Home();
            Utils.ShowMessage(t, "json");
        }

        private async void ButtonDetail_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.DetailFilm("phim/to-chuc-bong-dem-uncle-2972/");
            Utils.ShowMessage(t, "json");
        }
    }
}
