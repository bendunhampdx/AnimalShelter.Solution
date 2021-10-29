# _Animal Shelter_

#### By _Ben Dunham_
<br/>

#### _Animal Shelter for Cats and Dogs_
<br/>

This app is a basic C# API for an animal shelter for cats and dogs.

<hr>
<br/>

## Technologies Used
* _C#_
* _NuGet_
* _.NET 5_
* _MySql_
* _ASP.NET Core_
* _Entity Framework_
* _Swagger_


## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run the console app.
- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)

### Setup/Installation

1. Clone [this repository](https://github.com/bendunhampdx/AnimalShelter.Solution/tree/refactor) to an empty folder or to your desktop, or download and open the Zip on your local machine. Instructions for cloning can be found [here](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository-from-github/cloning-a-repository).
2. Navigate to the ```AnimalShelter.Solution/tree/refactor``` directory on your computer
3. Open the AnimalShelter.Solution/tree/refactor folder in your preferred text editor
4. Set up your SQL database using MySQL:
   - Create a new `appsettings.json` file in the ```AnimalShelter.Solution/tree/refactor``` directory
   - Copy the following code into the `appsettings.json` file, replacing `YOUR_PASSWORD` with your MySQL password:
   ```
        "Logging": {
         "LogLevel": {
           "Default": "Warning",
           "System": "Information",
           "Microsoft": "Information"
         }
      },
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=trees;uid=root;pwd=YOUR_PASSWORD;"
         }
     }
   ```
   - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) and hit enter to launch MySQL servers
5. To run the console app:
 - Navigate to ```Trees.Solution``` in your command line
   - Run:
     - `dotnet restore` to restore the dependencies that are listed in ```Trees.Solution.csproj```
     - ```dotnet ef migrations add Initial``` and ```dotnet ef database update```
   - Run ```dotnet run``` to run the project

6. Visit the application via web browser at: `http://localhost:5000/`

## Documentation and Routes

### Swagger

_To access Swagger Documentation for API calls for GET, PUT, and POST:_
 - Run the application from `AnimalShelter.Solution` in your command line
 - Once the application is running, go to `http://localhost:5000`
    - You can also follow this link while the program is running [Swagger](http://localhost:5000).

### Manual Routes

- GET `/api/animals`
    - Returns all animals in database

- GET `/api/animals/{id}`
    - Returns a single animal with the specified ID

- POST `/api/animals`
    - Creates a new animal in the database

- PUT `/api/animals/{id}`
    - Edits the existing animal with the specified id

- DELETE `/api/animals/{id}`
    - Deletes the existing animal with the specified id


## Known Issues
* _None_

## License

_[GPL](https://opensource.org/licenses/gpl-license)_
_Copyright (c) 2021, Ben Dunham_

## Contact Information  

Ben Dunham <bendunhampdx@gmail.com>
 
_Please feel free to reach out to us with suggested changes/improvements, or if you have any questions._