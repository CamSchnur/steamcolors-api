using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace steamcolors_api
{
    public static class SteamInterface
    {
        /// <summary>
        /// Given a Steam AppID, returns a link to the game's vertical poster thumbnail from Steam's Website
        /// </summary>
        /// <param name="appID"></param>
        /// <returns></returns>
        public static String GeneratePosterLink(string appID)
        {
            //vertical thumbnail URLs are formatted like this
            //https://steamcdn-a.akamaihd.net/steam/apps/255220/library_600x900.jpg
            //higher res version that we won't use:
            //https://steamcdn-a.akamaihd.net/steam/apps/255220/library_600x900_2x.jpg

            if (!long.TryParse(appID, out long result))
            {
                //Steam App IDs should be numeric
                return null;
            }
            return $"https://steamcdn-a.akamaihd.net/steam/apps/{appID}/library_600x900.jpg";
        }

    }
}
