# _ParksLookupAPI_

#### By _**Erin McCulley**_

#### _Beginners Web Development_

## Technologies Used

* _C#_
* _ASP.NET Core_
* _Postman_
* _JSON_
* _Swagger_
* _Entity_
* _MySQL Workbench_
* _Dotnet ef_
* _Markdown_
* _Git / Github_
* _Terminal_

## Description

_Create an API for state and national parks. The API will list state and national parks. The API must have full CRUD functionality and will use Swagger Documentation._

## Setup/Installation Requirements

_To clone this repository:_

1. Click on the green "Code" button above this file list.
2. Copy the HTTPS link (this is the default option).
3. Open your local Terminal.
4. Navigate to the local directory where you want the cloned directory to go.
5. In your Terminal type "git clone" (without the quotes) then paste the URL you copied above. 
6. Press 'enter' and the cloned directory should be copied to your current working directory.

_To install C# and .NET:_

1. In your Terminal, navigate to ParksLookup.Solution/ParksLookup and type 'dotnet build' and 'dotnet watch run' to launch the web application.

_To set up MySQL Workbench:_

1. Download and install MySQL Workbench [here](https://www.mysql.com/products/workbench/).
2. Create an appsettings.json file !!! Add this file to your .gitignore !!! by adding: */appsettings.json to your .gitignore file.
3. Add appsettings.json file in your main project directory. Enter the following into your appsettings.json file

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-HERE];uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}

_To Set up Dotnet ef_

1. In your terminal type 'dotnet tool install --global dotnet-ef --version 5.0.1'
2. In the root directory of the project type 'dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0'
3. Next type 'dotnet ef migrations add Initial'
4. Then type 'dotnet ef database update' If everything worked correctly, you will have a database created for you!

_To Add Seed Data_

1. The ParksLookupContext.cs includes Seed Data with a few samples of State and National parks objects. These data can be used to search by each property type, and view endpoints through the swagger link.
2. To migrate the seed data type 'dotnet ef migrations add SeedData' then type 'dotnet ef database update'

_Exploring API Endpoints with Swagger_

1. To view the Swagger UI / Documentation type 'dotnet run' in the project's root directory, then open your browser to 'localhost:5000/swagger.
2. Click 'GET' /api/parks
3. Click 'Try it out'
4. Then enter any of the valid search parameters within the Seed Data and click 'Execute'
5. Swagger will provide the Curl and Request URL for the query.

## Known Bugs

* N/A

## License
MIT License

Copyright (c) [2021] [Erin McCulley]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
