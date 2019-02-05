var urlParams = new URLSearchParams(window.location.search);
var code = urlParams.get('code');



if (code == null) {
    document.getElementById("my_button").onclick = function () { GetSpotifyAuthorization() };
}

function GetSpotifyAuthorization() {
    var data = {
        client_id: "e7b6b7ff0e444353aa5edfa5ea1728cb",
        response_type: "code",
        scope: "user-library-read",
        redirect_uri: "https://localhost:44356/"
    };

    var body = "";
    for (var key in data) {
        if (body.length) {
            body += "&";
        }
        body += key + "=";
        body += encodeURIComponent(data[key]);
    }

    window.location.href = "https://accounts.spotify.com/en/authorize/?" + body;
}





function httpGetAsync(theUrl, callback) {
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.onreadystatechange = function () {
        if (xmlHttp.readyState == 4 && xmlHttp.status == 200)
            callback(xmlHttp.responseText);
    }
    xmlHttp.open("GET", theUrl, true); // true for asynchronous 
    xmlHttp.send(null);
}
