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
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.Film_Decu();
            txtResult.Text = t;
        }

        private async void ButtonTopNew_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.Film_TopNew();
            txtResult.Text = t;

        }

        private async void ButtonTheLoai_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmToTheLoai("1", DataFilm_HDPHim.Enum.Genre.phieuluu);
            txtResult.Text = t;
        }

        private async void ButtonLe_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmLe("1");
            txtResult.Text = t;
        }

        private async void ButtonBo_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmBo("1");
            txtResult.Text = t;
        }

        private async void ButtonKinhDien_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmKinhDien("1");
            txtResult.Text = t;
        }

        private async void ButtonRap_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmToPageChieuRap("1");
            txtResult.Text = t;
        }

        private async void ButtonQuocGia_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmToCountry("1", DataFilm_HDPHim.Enum.Country.Korean);
            txtResult.Text = t;
        }

        private async void ButtonTop10Imdb_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.FilmTop10Imdb();
            txtResult.Text = t;
        }

        private async void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            var t = await DataFilm_HDPHim.Config.Film_Home();
            txtResult.Text = t;
        }

        private async void ButtonDetail_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUri.Text.Trim()))
            {
                txtUri.Text = "phim/bi-mat-cua-lang-achiara-3118/";
            }
            var t = await DataFilm_HDPHim.Config.DetailFilm(txtUri.Text);
            txtResult.Text = t;
        }

        private async void ButtonProfile_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUri.Text.Trim()))
            {
                txtUri.Text = "ho-so/yook-sung-jae-19908/";
            }
            var t = await DataFilm_HDPHim.Config.ProFile(txtUri.Text);
            txtResult.Text = t;
        }

        private async void ButtonEpisode_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUri.Text.Trim()))
            {
                txtUri.Text = "phim/bi-mat-cua-lang-achiara-3118/xem-phim.html";
            }
            var t = await DataFilm_HDPHim.Config.Episode(txtUri.Text);
            txtResult.Text = t;
        }

        private async void ButtonQuality_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUri.Text.Trim()))
            {
                txtUri.Text = "phim/bi-mat-cua-lang-achiara-3118/xem-phim.html";
            }
            var t = await DataFilm_HDPHim.Config.Quality(txtUri.Text);
            txtResult.Text = t;
        }
    }
}
