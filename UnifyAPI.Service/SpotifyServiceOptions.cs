using System;
using System.Collections.Generic;
using System.Text;

namespace UnifyAPI.Service
{
    public class SpotifyServiceOptions
    {
        // A feature of ASP where only the options listed as properties here will be grabbed from 
        // the app settings file 
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUri { get; set; }
    }
}
