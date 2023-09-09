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
   
The application will be accessible at http://localhost:5000 (or https://localhost:5001 with HTTPS).

## Usage
Go to the home page to view the contact list.
Click "Add" to create a new contact.
Click a contact in the list to view and edit their information.
On the preview page, you can edit the information or delete the contact.

## Contribution
Feel free to contribute improvements, bug fixes or additional features. Open an issue or submit a pull request with your changes.

## License
This project is licensed under the MIT [License.]([https://www.teste.com](https://github.com/melvintivane/ustm-contact-management/blob/main/LICENSE)https://github.com/melvintivane/ustm-contact-management/blob/main/LICENSE) See the LICENSE file for details.
