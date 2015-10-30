using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Project_Film
{
    public class Utils
    {
        internal static async Task ShowMessage(string content, string title = "")
        {
            var msg = new MessageDialog(content, title);
            await msg.ShowAsync();
        }
    }
}
