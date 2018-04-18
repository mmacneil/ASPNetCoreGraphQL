# ASPNetCoreGraphQL
Sample project based on <a href="https://fullstackmark.com/post/17/building-a-graphql-api-with-aspnet-core-2-and-entity-framework-core">the blog post</a> demonstrating how to build a GraphQL service powered by ASP.NET Core 2, Entity Framework Core and <a href="https://github.com/graphql-dotnet/graphql-dotnet" target="_blank">graphql-dotnet</a>.

<img src="https://fullstackmark.com/img/posts/17/interactive-graphql-queries.gif" />


## Development Environment
-  .NET Core 2.0 SDK
- Visual Studio Code v1.21.1 (Should also work in VS2017)
- Sql Server Management Studio 2017
 
## Project Setup

The project is configured to create and <a href="https://github.com/mmacneil/ASPNetCoreGraphQL/blob/master/src/backend/NHLStats.Data/NHLStatsSeedData.cs">seed the database</a> at runtime if necessary so there shouldn't be any initial setup required. Simply start the debugger from the IDE or run it directly using the CLI dotnet run command from the root of the \NHLStats.Api folder.

After running the project, verify the database was created in your local Sql Server LocalDB instance.

<img src="https://fullstackmark.com/img/posts/17/graphql-nhlstats-demo-sql-server-database.png" />
