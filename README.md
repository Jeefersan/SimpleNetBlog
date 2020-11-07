# SimpleNetBlog
SimpleNetBlog is a simple blog engine written in ASP.NET Core MVC.
It's intended to be used by a single admin user.

Feel free to clone this repo and adjust it to your needs.



## How to setup
First install .NET Core SDK 3.1. Download from [here](https://dotnet.microsoft.com/download)

Then install MS SQL Server from [here](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

- ``git clone git@github.com:Jeefersan/SimpleNetBlog.git``

If you don't have sass installed, do it now:

- ```cd SimpleNetBlog && npm install --save-dev sass```

- ```echo "{"ConnectionStrings":{"DefaultConnection":"YOUR-CONNECTION-STRING;"}}" >> appsettings.json```

In your startup.cs file:

- `services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(
                     Configuration.GetConnectionString("DefaultConnection")));`

- ```dotnet-ef migrations add "init"```

- ```dotnet-ef database update```

And finally:

- ```dotnet run```

Then login with username *admin*
and password *password123*

Change password and enjoy!

## Web api
- ```/api/post/{id?}```

[Example](#http://simplenetblog.azurewebsites.net/api/post/3)

- ```{"postId":3,"title":"Just some test post","content":"<p>Test Test Test</p>","createdDate":"2020-11-06T23:59:17.7514192","lastUpdatedDate":null}```
