namespace PostcodeIO.API
{
    //The full postcode info for a requested postcode.
    public class PostcodeInfo
    {
        //The HTTP status response from Postcodes.IO.
        public int status;

        //If an error is returned, it is held here.
        public string error;

        //The actual result of the API call.
        public PostcodeResult result;
    }

    public class PostcodeResult
    {
        //The returned postcode.
        public string postcode;

        //The quality of the postcode.
        public int quality;

        //Eastings, northings.
        public int eastings, northings;

        //Country the postcode is in, region.
        public string country;
        public string region;

        //The NHS domain of the postcode, primary care trust.
        public string nhs_ha;
        public string primary_care_trust;

        //Longitude, latitude.
        public double longitude;
        public double latitude;

        //The european electoral region of the postcode.
        public string european_electoral_region;

        //LSOA, MSOA
        public string LSOA, MSOA;

        //Postcode incode/outcode (region and subregion).
        public string incode, outcode;

        //Parliamentary/council stuff.
        public string parliamentary_constituency, admin_district, parish, admin_ward, admin_county, ced, ccg, nuts;

        //Codes for this postcode.
        PostcodeCodes codes;
    }

    //The set of assigned codes for this postcode.
    public class PostcodeCodes
    {
        public string admin_district, admin_county, admin_ward, parish, parliamentary_constituency, ccg, ced, nuts;
    }
}