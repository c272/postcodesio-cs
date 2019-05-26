using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostcodeIO.API;

namespace PostcodeIO_API_Wrapper
{
    class Program
    {
        //API built to grab postcodes from Postcodes.IO.
        //Documentation at https://postcodes.io/docs.

        static void Main(string[] args)
        {
            //Test a basic postcode.
            var pcinfo = PostcodeAPIFetcher.GetPostcodeInfo("FK6 6BL");

            //Print some information.
            Console.WriteLine("This postcode is in country:");
            Console.WriteLine(pcinfo.country);
            Console.WriteLine("This postcode is in region:");
            Console.WriteLine(pcinfo.region);
        }
    }
}
