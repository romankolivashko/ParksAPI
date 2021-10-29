
<br>
<p align="center">
  <u><big>|| <b>National Parks API</b> ||</big></u>
</p>
<p align="center">
    <!-- Project Avatar/Logo -->
    <br>
    <a href="https://github.com/romankolivashko">
        <img src="https://images.unsplash.com/photo-1502856755506-d8626589ef19?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/romankolivashko/romankolivashko">
            <strong>Roman Kolivashko</strong>
        </a>
    </p>
    <!-- Project Shields -->

<p align="center">
  <small>Initiated October 29th, 2020. Updated October 29th, 2021.</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/romankolivashko/ParksAPI"><big>Project Docs</big></a> ·
    <a href="https://github.com/romankolivashko/ParksAPI/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/romankolivashko/ParksAPI/issues"><big>Request Feature</big></a>
</p>

------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    * <a href="#🌟-acknowledgements">Acknowledgements</a>
    
------------------------------

## 🌐 About the Project

### 📖 Description
This API uses RESTful principles, version control, and has integrated version of swagger for documentation purposes. The user is able to see the in-use version of the API when using Postman.

### 🦠 Known Bugs

* This is not a real API, which is the greatest shame of all.

### 🛠 Built With
* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.20 for Linux](https://dev.mysql.com/)
* [Entity Framework Core 5.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - Swashbuckle 6.2.3](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [Atom](https://nodejs.org/en/)
     * Option 2: [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [Parks API repository here](https://github.com/romankolivashko/ParksAPI.git).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/romankolivashko/ParksAPI.git`
  5) Run the command `cd ParksApi.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Parks API repository here](https://github.com/romankolivashko/ParksAPI).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the ParksApi.Solution/ParksApi directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=parks;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to ParksApi.Solution/ParksApi directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParksApi.Solution/ParksApi`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to ParksApi.Solution/ParksApi directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParksApi.Solution/ParksApi`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the ParksApi.Solution API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `https://localhost:5000/`

### Note:
Swagger will redirect to `https://localhost:5000/index.html` providing API documentation


..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Versioning Example Query, here version 1 is called
```
https://localhost:5000/api/parks/2?api-version=1.0
```

#### Sample JSON Response
```
{
joinEntities: [ ],
parkId: 2,
name: "Badlands",
description: "The Badlands are a collection of buttes, pinnacles, spires, and mixed-grass prairies. The White River Badlands contain the largest assemblage of known late Eocene and Oligocene mammal fossils. The wildlife includes bison, bighorn sheep, black-footed ferrets, and prairie dogs.",
state: "South Dakota",
area: "242,755.94 acres (982.4 km2)",
visitors: 916932,
yearEstablished: 1978
}
```
#### Versioning Example Query, here version 2 (ptortected version) is called
```
https://localhost:5000/api/parks/2?api-version=2.0
```

#### Sample JSON Response
```
Api Key was not provided
```
Note: version 1.0 is set to be default, to be able to call version 2, make sure to create ApiKey object  in `appsettings.json` file, then use that key upon API call (Postman --> Authorisation --> Type: API Key --> Value: yourKey ), here is example of `appsetting.json` file with ApiKey.
```
{ 
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ApiKey": "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxx",
  ...
}
```

..........................................................................................

### US National Parks
Access parks info from around the world.

#### Park HTTP Requests 
```
GET /api/parks
POST /api/parks
GET /api/parks/{id}
PUT /api/parks/{id}
DELETE /api/parks/{id}
```

#### US States HTTP Requests 
```
GET /api/states
POST /api/states
GET /api/states/{id}
PUT /api/states/{id}
```


#### Example Query
```
https://localhost:5004/api/parks/?state=Florida
```

#### Sample JSON Response
```
{
joinEntities: [ ],
parkId: 4,
name: "Dry Tortugas",
description: "The islands of the Dry Tortugas, at the westernmost end of the Florida Keys, are the site of Fort Jefferson, a Civil War-era fort that is the largest masonry structure in the Western Hemisphere. The park is home to undisturbed coral reefs and shipwrecks, and is only accessible by plane or boat.",
state: "Florida",
area: "64,701.22 acres (261.8 km2)",
visitors: 48543,
yearEstablished: 1992
},
{
joinEntities: [ ],
parkId: 6,
name: "Everglades",
description: "The Everglades are the largest tropical wilderness in the United States. This mangrove and tropical rainforest ecosystem and marine estuary is home to 36 protected species, including the Florida panther, American crocodile, and West Indian manatee. Some areas have been drained and developed; restoration projects aim to restore the ecology.",
state: "Florida",
area: "1,508,938.57 acres (6,106.5 km2)",
visitors: 702319,
yearEstablished: 1934
}
```

------------------------------

### 🤝 Contributors

| Author | GitHub | Email |
|--------|:------:|:-----:|
| [Roman Kolivashko](https://www.linkedin.com/in/rkolivashko/) | [RomanKolivashko](https://github.com/romankolivashko/) |  [rkolivashko@gmail.com](mailto:rkolivashko@gmail.com) |

------------------------------

### ✉️ Contact and Support

If you have any feedback or concerns, please contact one of the contributors.

<p>
    <a href="https://github.com/romankolivashko/ParksApi/issues">Roman Kolivashko</a> 
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2021 Roman Kolivashko. All Rights Reserved.

```
MIT License

Copyright (c) 2021 Roman Kolivashko.

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
```

------------------------------

### 🌟 Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

------------------------------

<center><a href="#">Return to Top</a></center>