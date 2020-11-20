[![Build Status](https://codingflow.visualstudio.com/NorthwindTraders/_apis/build/status/NorthwindTraders%20-%20CI?branchName=master)](https://codingflow.visualstudio.com/NorthwindTraders/_build/latest?definitionId=22&branchName=master)

# NorthwindTraders

OnlineStore API application used to better understand the Clean Architecture and coding best practices. The architecture and design of the project is explained in the video:

* [Clean Architecture with ASP.NET Core 2.1](https://youtu.be/_lwCVE_XgqI) ([slide deck](/Docs/Slides.pdf))

The initial construction of this project is explained in the following blog posts:

* [Code: Northwind Traders with Entity Framework Core](https://jasontaylor.dev/northwind-traders-with-entity-framework-core/)
* [Create Northwind Traders Code First with Entity Framework Core – Part 1](https://jasontaylor.dev/create-northwind-traders-code-first-with-entity-framework-core-part-1/)
* [Create Northwind Traders Code First with Entity Framework Core – Part 2](https://jasontaylor.dev/create-northwind-traders-code-first-with-entity-framework-core-part-2/)

## Getting Started
Use these instructions to get the project up and running.

### Prerequisites
If you plan on using .NET Core 3.0 or later you need to recreate the architecture and you will need the following tools:

* [Visual Studio Code or Visual Studio 2019](https://visualstudio.microsoft.com/vs/) (version 16.3 or later)
* [.NET Core SDK 3](https://dotnet.microsoft.com/download/dotnet-core/3.0)
 * [Node.js](https://nodejs.org/en/) (version 10 or later) with npm (version 6.11.3 or later)

If you plan on using the existing architecture you just need 
* [Visual Studio 2017]
* [.NET Core SDK 2]

### Setup
Follow these steps to get your development environment set up:

  1. Clone the repository
  2. At the root directory, restore required packages by running:
      ```
     dotnet restore
     ```
  3. Next, build the solution by running:
     ```
     dotnet build
     ```
  4. Next, within the PackageManager
	1. Select default prject as Persistence
	2. Execute Update-Database

Because we use EF Core when we want to add an update to the database:
	1. Go to PackageManager
	2. Select default prject as Persistence
	3. Add-Migration [MigrationName]
		3.1 Remove-Migration - to remove the latest migration added
	4. Update-Database

## Technologies
* .NET Core 2
* ASP.NET Core 2
* Entity Framework Core 2
* React
