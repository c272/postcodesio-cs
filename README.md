![Postcode C# Logo](logo.png)

# Postcodes.IO API
*A basic wrapper written for C# users.*

This is a basic wrapper for the [postcodes.io API,](http://postcodes.io) which can grab information about single postcodes and the raw JSON string for other manipulation. To get started, read the below guide.

## Getting Started
First, clone the repo/download the `.cs` files that aren't `Program.cs`, and add them to your project by right clicking your project's name in the solution browser, then going to `Add -> Existing Item` and finding the file inside your project folder.

When that's done, where you want to use the wrapper, add `using PostcodeIO.API;` at the top of the file.

## Getting Postcode Information
To get information for an individual postcode, you can do this:
```
//Test a basic postcode.
var pcinfo = PostcodeAPIFetcher.GetPostcodeInfo("FK6 6BL");

//Print some information.
Console.WriteLine("This postcode is in country:");
Console.WriteLine(pcinfo.country);
Console.WriteLine("This postcode is in region:");
Console.WriteLine(pcinfo.region);
```

## Getting Raw Responses
To get a raw response for an individual postcode, you can do this:
```
string contents = PostcodeAPIFetcher.GetRawResponse("FK6 6BL");
```

## Documentation?
This wrapper has the same structure as the JS version, so you can just go to [the official docs,](http://postcodes.io/docs) or you can go inside the `PostcodeInfo.cs` file to see commented docs.
