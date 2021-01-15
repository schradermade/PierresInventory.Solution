<br>
<p align="center">
  <u><big>|| <b>Dr Sillystringz Factory Manager</b> ||</big></u>
  <br><br>
  <u><b>by Nathan Schrader - January 8th, 2021</b></u>
</p>
<p align="center">
    <!-- Project Image -->
    <br>
    <a>
        <img src="LINK-TO-IMAGE-GOES-HERE">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- My GitHub Link -->
    <p align="center">
        <a href="https://github.com/schradermade/SillystringzFactory.Solution">
            <strong>Link to GitHub Repo</strong>
        </a> 
    </p>
</p>

<p align="center">
  <small>This was created on Jan 8th, 2021.</small>
</p>

---

# <u>Table of Contents</u>

  - <a href="#Description">Description</a>
  - <a href="#known-bugs">Known Bugs</a>
  - <a href="#technologies-used">Technologies Used</a>
  - <a href="#getting-started">Getting Started</a>
  - <a href="#setup-and-use">Setup and Use</a>
  - <a href="#contact-and-support">Contact</a>
  - <a href="#🛠-license">License</a>


---

# 📖 Description

This project was created in Week 10 of the Epicodus Coding School, using C#/.NET MVC. The objective was to build a web application for a factory to track the maintenance of their machines.

It has a many-to-many SQL relationship that connects patients with their doctors. You can add, view and edit doctors and patients. You can also add or update the relationship between doctors and patients.

# 🦠 Known Bugs

At this time, there are no known bugs. If you see spot a bug feel free to make a pull request.

# 🛠 Technologies Used

- [Visual Studio Code](https://code.visualstudio.com/)
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
- [MySQL](https://dev.mysql.com/)
- [MySql Workbench](https://www.mysql.com/products/workbench/)
- [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
- [MSTest](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)
- Object Oriented Programming

# Getting Started

## Install .NET Core

- On macOS Mojave or later
  - [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
- On Windows 10 x64 or later
  - [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

## Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal for macOS or PowerShell for Windows.

## Install MySQL Workbench

[Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

## Code Editor

To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

1. Code Editor Download:
   - Option 1: [Atom](https://nodejs.org/en/)
   - Option 2: [VisualStudio Code](https://www.npmjs.com/)
2. Click the download most applicable to your OS and system.
3. Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
4. Optionally, create a [GitHub Account](https://github.com)

<hr>

## Database Settings

1. Create a new file in the DrOffice directory named `appsettings.json`
2. Add in the following code snippet to the new appsettings.json file:

```
{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=dr_sillystringz;uid=root;pwd=YourPassword;"
  }
}
```

3. Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

# Setup and Use

- copy the repository URL and paste it after this GIT command `git clone {repository url}`
- after opening the repository in your code reader, run `dotnet build`
- once build is complete and no errors are thrown, run `dotnet watch run` in the terminal

  ```

## Database

1. Navigate to the DrSillystringz directory using the MacOS Terminal or Windows Powershell
2. Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

---

# Contact and Support

If you have any feedback or concerns, please contact <natecschrader@gmail.com>.

---

# 🛠 License

This repository is licensed under the MIT license.

Copyright (c) 2020 by _Nathan Schrader_

```

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