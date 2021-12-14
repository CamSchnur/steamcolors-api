using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace steamcolors_api.Models
{
    public class SteamColors
    {
        public String AppID { get; set; }
        public String ThumbnailURL { get; set; }
        public ColorPalette Colors
        { get; set; }
    }
}
