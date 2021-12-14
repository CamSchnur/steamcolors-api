using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using steamcolors_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace steamcolors_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SteamColorsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<SteamColors> Get(String id = "")
        {
            SteamColors steamGame = new SteamColors();
            steamGame.AppID = id;
            steamGame.ThumbnailURL = SteamInterface.GeneratePosterLink(steamGame.AppID);
            steamGame.Colors = ColorPaletteFinder.GetColorPalette(steamGame.ThumbnailURL);
            return new List<SteamColors>() { steamGame };
        }
    }
}
