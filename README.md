# ASPNetCoreGraphQL
Sample project based on <a href="https://fullstackmark.com/post/17/building-a-graphql-api-with-aspnet-core-2-and-entity-framework-core">the blog post</a> demonstrating how to build a GraphQL service powered by ASP.NET Core 2.2, Entity Framework Core and <a href="https://github.com/graphql-dotnet/graphql-dotnet" target="_blank">graphql-dotnet</a>.

<img src="https://fullstackmark.com/img/posts/17/interactive-graphql-queries.gif" />

"ASPNetCoreGraphQL is being sponsored by the following tool; please help to support us by taking a look and signing up to a free trial"

<a href="https://tracking.gitads.io/?repo=ASPNetCoreGraphQL">
 <img src="https://images.gitads.io/ASPNetCoreGraphQL" alt="GitAds"/></a>
 
## Development Environment
-  .NET Core 2.2 SDK
- Visual Studio Code v1.21.1 (Should also work in VS2017)
- Sql Server Management Studio 2017
 
## Project Setup

The project is configured to create and <a href="https://github.com/mmacneil/ASPNetCoreGraphQL/blob/master/src/backend/NHLStats.Data/NHLStatsSeedData.cs">seed the database</a> at runtime if necessary so there shouldn't be any initial setup required. Simply start the debugger from the IDE or run it directly using the CLI dotnet run command from the root of the \NHLStats.Api folder.

After running the project, verify the database was created in your local Sql Server LocalDB instance.

<img src="https://fullstackmark.com/img/posts/17/graphql-nhlstats-demo-sql-server-database.png" />

Alternatively, you can also apply the existing <a href="https://github.com/mmacneil/ASPNetCoreGraphQL/tree/master/src/backend/NHLStats.Data/Migrations">migrations</a> to create the database by running <code>dotnet ef database update</code> from the \NHLStats.Data folder. The seed data will be inserted on first run of the application.

The API is configured to run on port 5000, if this conflicts with some other service on your computer you can change it <a href="https://github.com/mmacneil/ASPNetCoreGraphQL/blob/master/src/backend/NHLStats.Api/Program.cs">here</a>.

## Contact

mark@fullstackmark.com
