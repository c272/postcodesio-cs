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
        /// <summary>
        /// Get the information about a given postcode in class form.
        /// </summary>
        /// <param name="postcode">A UK valid postcode.</param>
        /// <returns>A PostcodeResult object.</returns>
        public static PostcodeResult GetPostcodeInfo(string postcode)
        {
            string contents = GetRawResponse(postcode);

            //Deserializing using Newtonsoft.JSON to a PostcodeInfo object.
            var postcodeInfo = JsonConvert.DeserializeObject<PostcodeInfo>(contents);

            //Checking for errors.
            if (postcodeInfo.Status != 200)
            {
                throw new Exception(postcodeInfo.Error);
            }

            //Returning.
            return postcodeInfo.Result;
        }

        /// <summary>
        /// Get the raw JSON response from the API for a given postcode.
        /// </summary>
        /// <param name="postcode">The postcode to fetch.</param>
        /// <returns>Raw JSON string.</returns>
        public static string GetRawResponse(string postcode)
        {
            //Replace any spaces in the postcode with "%20" for URL encoding.
            postcode = postcode.Replace(" ", "%20");

            //Grabbing the JSON string from API.
            string contents;
            using (var wc = new System.Net.WebClient())
            {
                contents = wc.DownloadString("http://api.postcodes.io/postcodes/" + postcode);
            }

            return contents;
        }
    }
}
