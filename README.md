# Learning ASP.NET Razor Pages with a Northwind Database

Building a web application on ASP.NET driven by interactions with Copilot.

## Get started

Set the connections string as a local secret:

```powershell
# At the root of the solution
dotnet user-secrets init --project ./data/RazorApp.Data.csproj
dotnet user-secrets set "ConnectionString" $PATH_TO_SQLITE_FILE --project .\data\RazorApp.Data.csproj
```

Specifying the data source for a local database as a user secret is more convenient than using an environment variable, unless Docker is involved.

## References

* [Safe storage of app secrets in development in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-10.0)