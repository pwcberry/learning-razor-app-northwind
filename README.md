# Learning ASP.NET Razor Pages with a Northwind Database

Building a web application on ASP.NET driven by interactions with Copilot.

## Get started

Set the connections string as a local secret:

```powershell
# At the root of the solution
dotnet user-secrets init --project ./data/RazorApp.Data.csproj
dotnet user-secrets set "ConnectionString" $PATH_TO_SQLITE_FILE --project .\data\RazorApp.Data.csproj
```

## References

* [Safe storage of app secrets in development in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-10.0)