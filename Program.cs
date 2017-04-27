using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.Services;
using System.Security.Cryptography.X509Certificates;
using Google.Apis.Auth.OAuth2;
using System.Collections.Generic;
using System.Linq;
using System;

// Minimal boilerplate C# Google Analytics client code.
// Adapted from Logan G's excellent answer here...
// http://stackoverflow.com/questions/10306872/use-google-analytics-api-to-show-information-in-c-sharp
// http://stackoverflow.com/users/1980816/logan-g
// You'll need a Google Service email address and a P12 key file to
// set the key and email variables below. Go to 
// https://console.developers.google.com/iam-admin
// and create a service account. Use the options menu to create a P12
// key (not a JSON key). Then log in to analytics.google.com
// and use ADMIN/User Management to add your service email
// address with Read & Analyze permissions.
// Do a nuget install packages.config in the Packages subdirectory.
// Then build and run! Good luck! JOS 2017-04-27

class Program {

    static void Main(string[] args) {
        string key = "";
        string email = "";
        GoogleAnalyticsAPI ga = new GoogleAnalyticsAPI( key, email);
        IList<Profile> profiles = ga.GetAvailableProfiles();
        Profile profile = profiles[0];
        DateTime end = DateTime.Now;
        DateTime start = DateTime.Now.AddDays( -7.0);
        string[] metrics = { "ga:sessions"};
        string[] dimensions = {};
        GoogleAnalyticsAPI.AnalyticDataPoint adp = ga.GetAnalyticsData(profile.Id, dimensions, metrics, start, end);
        Console.Out.WriteLine( String.Format( "{0} {1} {2} {3}", adp.Rows[0][0], metrics[0], 
                                    start.ToString( "yyyy-MM-dd" ), end.ToString( "yyyy-MM-dd" )));
    }
}

