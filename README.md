### Google Analytics C# boilerplate

#### Google setup

You'll need a Google Service email address and a P12 key file to
set the key and email variables below. Go to 
https://console.developers.google.com/iam-admin
and create a service account. Use the options menu to create a P12
key (not a JSON key). Then log in to analytics.google.com
and use ADMIN/User Management to add your service email
address with Read & Analyze permissions.

#### Build

ganalytics.csproj and packages.config target .Net Framework 4. Look out
for bin/Debug/ganalytics.exe.config: it fixes the System.Net.Http.Primitives
reference version error. You'll need to do a nuget install packages.config
in the Packages subdirectory. Then build and run! Good luck!

#### Acknowledgements
Adapted from [Logan G](http://stackoverflow.com/users/1980816/logan-g)'s
[excellent stackoverflow answer](http://stackoverflow.com/questions/10306872/use-google-analytics-api-to-show-information-in-c-sharp).





