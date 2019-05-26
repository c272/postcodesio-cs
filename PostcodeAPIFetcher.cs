using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PostcodeIO.API
{
    public class PostcodeAPIFetcher
    {
        public static PostcodeResult GetPostcodeInfo(string postcode)
        {
            //Replace any spaces in the postcode with "%20" for URL encoding.
            postcode = postcode.Replace(" ", "%20");

            //Grabbing the JSON string from API.
            string contents;
            using (var wc = new System.Net.WebClient())
            {
                contents = wc.DownloadString("http://api.postcodes.io/postcodes/" + postcode);
            }

            //Serializing using Newtonsoft.JSON to a PostcodeInfo object.
            var postcodeInfo = JsonConvert.DeserializeObject<PostcodeInfo>(contents);

            //Checking for errors.
            if (postcodeInfo.status != 200)
            {
                throw new Exception(postcodeInfo.error);
            }

            //Returning.
            return postcodeInfo.result;
        }
    }
}
