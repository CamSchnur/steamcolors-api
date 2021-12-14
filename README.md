# steamcolors-api

Analyzing Steam Games based on the color palette of their cover image


# Usage

Build & run docker image:
docker build -t steamcolorsapiimage -f Dockerfile .
docker run -d -p 8080:80 --name steam_colors_api steamcolorsapiimage  

Call API:
http://localhost:8080/SteamColors/?id={steamAppId}
(e.g. http://localhost:8080/SteamColors/?id=1455840)