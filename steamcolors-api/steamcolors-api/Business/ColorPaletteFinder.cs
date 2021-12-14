using ColorThiefDotNet;
using steamcolors_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.IO;

namespace steamcolors_api
{
    public static class ColorPaletteFinder
    {
        //Given a thumbnail image, returns color palette information for that image
        public static steamcolors_api.Models.ColorPalette GetColorPalette(string posterURL)
        {
            ColorThief colorThief = new ColorThief();
            Bitmap image = GetImageFromURL(posterURL);
            List<QuantizedColor> colorsList = colorThief.GetPalette(image, 5);
            Models.ColorPalette palette = new Models.ColorPalette();
            palette.Colors = new List<string>();
            colorsList.ForEach(c => palette.Colors.Add(c.Color.ToHexString()));
            return palette;
        }

        private static System.Drawing.Bitmap GetImageFromURL(String url)
        {
            Bitmap bitmap;
            using (WebClient client = new WebClient())
            {
                using (Stream stream = client.OpenRead(url))
                {
                    bitmap = new Bitmap(stream);
                }
            }
            return bitmap;
        }

    }
}
