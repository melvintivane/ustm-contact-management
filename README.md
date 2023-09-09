# ASP.NET Core MVC Contact Manager

This is a sample project of a contact management application developed in ASP.NET Core MVC. It allows you to add, view, edit and delete contacts in a database.

## System Requirements

- [ASP.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional)

## Settings

1. Clone this repository:

   ```shell
   git clone https://github.com/seu-usuario/gestor-de-contatos-mvc.git

2. Navigate to the project directory:
   ```shell
   cd gestor-de-contatos-mvc

3. Configure the database connection string in the appsettings.json file:
   ```shell
   "ConnectionStrings": {
       "DefaultConnection": "YourConnectionStringHere"
   }

4. Open the project in your development environment (Visual Studio or Visual Studio Code).

5. Open the NuGet Package Manager console and run the migration to create the database:
   ```shell
   dotnet ef database update

6. Launch the application:
   ```shell
   dotnet run

